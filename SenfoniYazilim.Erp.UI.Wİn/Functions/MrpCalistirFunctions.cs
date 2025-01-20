using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.General.CRP;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public static class MrpCalistirFunctions
    {
        public static IEnumerable<BaseHareketEntity> MrpCalistir(this ReceteBilgileriL anaRow, bool anaFonksiyon, decimal ihtiyacMiktari, DateTime ihtiyacTarihi, int id)
        {
            var listMib = new List<BaseHareketEntity>();
            
            Cursor.Current = Cursors.WaitCursor;

            using (var bll = new ReceteBilgileriBll())
            {
                var yigin = new StackFunction(50, 500);

                void ListeleDoldur(ReceteBilgileriL receteL, decimal aktarilanMiktar, int mrpBilgiId, DateTime baslamaTarihi)
                {
                    var idd = receteL.StokId;//receteL.StokId;
                    var recete = Bll.Functions.GetAnySingleOrListBll.GetRecete(x => x.StokId == idd && x.Varsayılan);
                    //var enty = bll.List(z => z.StokId == idd && z.Uretilebilir == Uretilebilir.AnaKod).Cast<ReceteBilgileriL>().FirstOrDefault();
                    if (recete==null/*enty == null*/)
                    {
                        //Messages.HataMesaji($" {receteL.StokKodu} Kodlu \n {receteL.StokAdi} Ürün İçin Recete Oluşturulmamıştır !");
                        return;
                    }
                    var rbl = recete.ReceteBilgileri?.Where(x => x.Uretilebilir != Uretilebilir.AnaKod)
                        .EntityListConvert<ReceteBilgileriL>().ToList();
                        //.Cast<ReceteBilgileriL>().ToList();//bll.List(x => x.ReceteId == enty.ReceteId && x.Uretilebilir != Uretilebilir.AnaKod).Cast<ReceteBilgileriL>().OrderByDescending(z => z.Uretilebilir).ToList();
                    rbl.ForEach(x =>
                    {
                        x.ReceteSeviyesi = x.Uretilebilir == Uretilebilir.AnaKod ? receteL.ReceteSeviyesi - 1 : receteL.ReceteSeviyesi;
                        x.BitisTarihi = baslamaTarihi;
                        x.ReceteOlusturulmaMiktari = recete.Miktar;
                        x.BagliOlduguAnaReceteId = receteL.BagliOlduguAnaReceteId;
                    });

                    foreach (var row in rbl)
                    {
                        var akMik = aktarilanMiktar / recete.Miktar;
                        listMib.Add(Uret(mrpBilgiId, aktarilanMiktar, baslamaTarihi, row));

                        if (row.Uretilebilir == Uretilebilir.Uretim)
                        {
                            row.BitisTarihi = row.BaslamaTarihiHesapla(baslamaTarihi, akMik);
                            row.ReceteSeviyesi++;
                            yigin.PushEntity(row);
                            yigin.PushIndex();
                        }
                    }

                    while (!yigin.EmptyIndex())
                    {
                        yigin.PopIndex();
                        var altEntity = (ReceteBilgileriL)yigin.PopEntity();
                        var ihtiyacMik = (altEntity.Miktar + altEntity.FireOrani * altEntity.Miktar)/altEntity.ReceteOlusturulmaMiktari * aktarilanMiktar;
                        if (altEntity == null) continue;
                        ListeleDoldur(altEntity, /*altEntity.Miktar * aktarilanMiktar*/ihtiyacMik, mrpBilgiId, altEntity.BitisTarihi);
                    }
                }
              
                DateTime _anaKodBaslamaTarihi;

                var receteRows = bll.List(y => y.ReceteId == anaRow.ReceteId).Cast<ReceteBilgileriL>().OrderBy(z => z.Uretilebilir);

                _anaKodBaslamaTarihi = anaRow != null ? anaRow.BaslamaTarihiHesapla(ihtiyacTarihi, ihtiyacMiktari) : ihtiyacTarihi;

                foreach (var row in receteRows)
                {
                    var bitisTarihi = row.Uretilebilir == Uretilebilir.AnaKod ? ihtiyacTarihi : _anaKodBaslamaTarihi;
                    row.ReceteSeviyesi = row.Uretilebilir == Uretilebilir.AnaKod ? row.ReceteSeviyesi : row.ReceteSeviyesi+ 1;
                    row.BagliOlduguAnaReceteId = anaRow.ReceteId;
                    
                    listMib.Add(Uret(id, ihtiyacMiktari, bitisTarihi, row));

                    if (row.Uretilebilir == Uretilebilir.Uretim)
                    {
                        var idd = row.StokId;
                        var baslamaTarihi = row.BaslamaTarihiHesapla(_anaKodBaslamaTarihi, ihtiyacMiktari/row.ReceteOlusturulmaMiktari );
                        var aktarilanMiktar = ihtiyacMiktari * (row.Miktar +row.FireOrani*row.Miktar)/ row.ReceteOlusturulmaMiktari;
                        row.ReceteSeviyesi = row.ReceteSeviyesi+1;

                        ListeleDoldur(row, aktarilanMiktar, id, baslamaTarihi);
                    }
                }
               
                if (anaFonksiyon)
                {
                    MrpKaydet(listMib);
                    //var sd = listMib.Cast<MalzemeIhtiyacBilgileriL>();
                    listMib.Clear();
                    //CrpKaydet(_listKib.Cast<BaseHareketEntity>().ToList());
                    //_listKib.Clear();
                }
            }
            Cursor.Current = Cursors.Default;
            return listMib;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mrpBilgiId"></param>
        /// <param name="aktarilanMiktar"></param>
        /// <param name="bitisTarihi"></param>
        /// <param name="row"></param>
        /// row a ait Recete Oluşturulma Miktarı sıfır olamaz. bir hata oluşmasını önlemek için 
        /// bir kontrol oluşturulmalı....
        /// <returns></returns>
        private static MalzemeIhtiyacBilgileri Uret( int mrpBilgiId, decimal aktarilanMiktar, DateTime bitisTarihi, ReceteBilgileriL row)
        {
            var receteAnaKod = GetAnySingleOrListBll.GetRecete(x => x.StokId == row.StokId && x.Varsayılan); //row.StokId.StokIdIleReceteAnaRow();

            var receteMakineOperasyonBilgileri = receteAnaKod?.ReceteOperasyonMakinaBilgileri
                .Where(x => x.VarsayilanMakina).ToList();

            var opList = receteAnaKod?.ReceteOperasyonMakinaBilgileri?.Where(x => x.OperasyonSirasi>0).OrderBy(x=>x.OperasyonSirasi).ToList();

            var mibEntity = new MalzemeIhtiyacBilgileri
            {
                ReceteId = receteAnaKod?.Id,
                MrpBilgileriId = mrpBilgiId,
                StokId = row.StokId,
                DepoId = /*row.Uretilebilir == Uretilebilir.AnaKod ? 1 : */row.TuketimDepoId,
                BagliOlduguUstReceteId = row.ReceteId,
                BagliOlduguAnaReceteId = row.BagliOlduguAnaReceteId,
                OperasyonId=row?.OperasyonId,
                BirimId=(long)row.TuketimBirimId,
                BirimIhtiyac = row.Miktar/row.ReceteOlusturulmaMiktari,
                FireMiktarı=row.Miktar*row.FireOrani,
                ToplamIhtiyac = row.Uretilebilir == Uretilebilir.AnaKod ? aktarilanMiktar : aktarilanMiktar * row.Miktar / row.ReceteOlusturulmaMiktari,
                BrutIhtiyac = row.Uretilebilir == Uretilebilir.AnaKod ? aktarilanMiktar : aktarilanMiktar * row.Miktar / row.ReceteOlusturulmaMiktari,
                NetIhtiyac = row.Uretilebilir == Uretilebilir.AnaKod ? aktarilanMiktar : aktarilanMiktar * row.Miktar / row.ReceteOlusturulmaMiktari,
                ReceteSeviyesi = row.ReceteSeviyesi,
                TavsiyeEdilenBaslamaTarihi = bitisTarihi,
                TalepTarihi = bitisTarihi,
                Uretim = row.Uretilebilir == Uretilebilir.AnaKod || row.Uretilebilir == Uretilebilir.Uretim,
                Uretilebilir=row.Uretilebilir
            };

            mibEntity.OperasyonSuresi = receteMakineOperasyonBilgileri?.Sum(x=>x.OperasyonSuresi);
            mibEntity.HazirlikSuresi = receteMakineOperasyonBilgileri?.Sum(x=>x.MakinaHazirlikSuresi);
            mibEntity.DegisimSuresi = receteAnaKod?.ReceteMakinaElemaniBilgileri?.Where(x => x.MakinaId == mibEntity.MakinaElemaniId).FirstOrDefault()?.DegisimSuresi;
            mibEntity.KapasiteIhtiyaci = Convert.ToDecimal(mibEntity.OperasyonSuresi) * mibEntity.NetIhtiyac / receteAnaKod?.Miktar + Convert.ToDecimal(mibEntity.HazirlikSuresi);
            mibEntity.TalepTarihi = bitisTarihi;
            mibEntity.TavsiyeEdilenBaslamaTarihi = mibEntity.KapasiteIhtiyaci != null ? Convert.ToDateTime(mibEntity.KapasiteIhtiyaci?.BaslamaTarihiHesapla(bitisTarihi)) : mibEntity.TalepTarihi;

            return mibEntity;
        }

        private static  void MrpKaydet(List<BaseHareketEntity> list)
        {
            using (var mibBll = new MalzemeIhtiyacBilgileriBll())
            {
                ((IBaseHareketGenelBll)mibBll).Insert(list);
            }
        }
        public static bool CrpKaydet(List<BaseHareketEntity> list)
        {
            return InstanceBaseHareketEntityBll<KapasiteIhtiyacBilgileri, KapasiteIhtiyacBilgileriBll>
                .InsertEntities(list);
                            //.In<ReceteBilgileri>(filter, x => x);
        }

        public static  ReceteBilgileriL StokIdIleReceteAnaRow(this long stokId)
        {
            using (var bll = new ReceteBilgileriBll())
            {
                var anaRow = (ReceteBilgileriL)bll.List(x => x.StokId == stokId && x.Uretilebilir == Uretilebilir.AnaKod).FirstOrDefault();
                return anaRow;
            }
        }
        public static IEnumerable<BaseHareketEntity> StokIdIleReceteList(this long stokId)
        {
            using (var bll = new ReceteBilgileriBll())
            {
                var receteList = bll.List(x => x.ReceteId == stokId&&x.Uretilebilir!=Uretilebilir.AnaKod);
                return receteList;
            }
        }
        public static ReceteBilgileriL ReceteIdIleReceteAnaRow(this long receteId)
        {
            using (var bll = new ReceteBilgileriBll())
            {
                var anaRow = (ReceteBilgileriL)bll.List(x => x.ReceteId == receteId && x.Uretilebilir == Uretilebilir.AnaKod).FirstOrDefault();
                return anaRow;
            }
        }
        public static IEnumerable<BaseHareketEntity> IstasyonOperasyonBilgileriList(this long istasyonId)
        {
            using (var bll = new IstasyonOperasyonBilgileriBll())
            {
                var operasyonMakinaList = bll.List(x => x.IstasyonId == istasyonId );
                return operasyonMakinaList;
            }
        }

    }

}
