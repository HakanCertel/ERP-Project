using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class VardiyaBll : BaseGenelBll<Vardiya>,IBaseGenelBll, IBaseCommonBll
    {
        public VardiyaBll() : base(KartTuru.Vardiya) { }

        public VardiyaBll(Control ctrl) : base(ctrl, KartTuru.Vardiya) { }

        public override BaseEntity Single(Expression<Func<Vardiya, bool>> filter)
        {
            return BaseSingle(filter, x => new VardiyaS
            {
                Id = x.Id,
                Kod = x.Kod,
                VardiyaAdi=x.VardiyaAdi,
                VardiyaSayisi=x.VardiyaSayisi,
                VardiyaBilgileriLastVersion=x.VardiyaBilgileriLastVersion,
                //HaftalikCalismaGunSayisi1=x.HaftalikCalismaGunSayisi1,
                //HaftalikCalismaGunSayisi2=x.HaftalikCalismaGunSayisi2,
                //HaftalikCalismaGunSayisi3=x.HaftalikCalismaGunSayisi3,
                //MesaiBaslamaSaati1=x.MesaiBaslamaSaati1,
                //MesaiBaslamaSaati2=x.MesaiBaslamaSaati2,
                //MesaiBaslamaSaati3=x.MesaiBaslamaSaati3,
                //MesaiBitisSaati1=x.MesaiBitisSaati1,
                //MesaiBitisSaati2=x.MesaiBitisSaati2,
                //MesaiBitisSaati3=x.MesaiBitisSaati3,
                //StandartMolaSuresi1=x.StandartMolaSuresi1,
                //StandartMolaSuresi2=x.StandartMolaSuresi2,
                //StandartMolaSuresi3=x.StandartMolaSuresi3,
                //YarimGun1=x.YarimGun1,
                //YarimGun2=x.YarimGun2,
                //YarimGun3=x.YarimGun3,
                //YarimBaslamaSaati1=x.YarimBaslamaSaati1,
                //YarimBaslamaSaati2=x.YarimBaslamaSaati2,
                //YarimBaslamaSaati3=x.YarimBaslamaSaati3,
                //YarimBitisSaati1=x.YarimBitisSaati1,
                //YarimBitisSaati2=x.YarimBitisSaati2,
                //YarimBitisSaati3=x.YarimBitisSaati3,
                //YarimGunMolaSuresi1=x.YarimGunMolaSuresi1,
                //YarimGunMolaSuresi2=x.YarimGunMolaSuresi2,
                //YarimGunMolaSuresi3=x.YarimGunMolaSuresi3,
                Durum=x.Durum,
                
            });
        }
    }
}
