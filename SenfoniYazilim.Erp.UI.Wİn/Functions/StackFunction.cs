using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public class StackFunction
    {
        List<BaseHareketEntity> receteBilgileriL = new List<BaseHareketEntity>();
        long[] _Id;
        int[] _sira;
        int tosId;
        int tosIndex;
        public StackFunction(int Id,int sira)
        {
            _Id = new long[Id];
            _sira = new int[sira];
            tosId = 0;
            tosIndex = 0;

        }

        public void PushEntity(BaseHareketEntity entity)
        {
            receteBilgileriL.Add(entity);
            tosId++;
        }
        public void PushIndex(/*int index*/)
        {
            _sira[tosIndex] = tosIndex;
            tosIndex++;            
        }
        public BaseHareketEntity PopEntity()
        {
            if (tosId == 0)
            {
                //Messages.HataMesaji("Entity yok, işlem geçersiz");
                return null;
            }
            tosId--;
            var entity = receteBilgileriL[tosId];
            receteBilgileriL.RemoveAt(tosId);
            return entity;
        }
        public int PopIndex()
        {
            //if (tosIndex == 0) return -1;
            //_sira[tosIndex-1] = _sira[tosIndex-1] - 1;
            //if (_sira[tosIndex - 1] != 0)
            //{
            //    var i= _sira[tosIndex - 1] = _sira[tosIndex - 1] - 1;
            //    return i;
            //}

            tosIndex--;
            return _sira[tosIndex];
        }
        public bool EmptyEntity()
        {
            return tosId==0;
        }
        public bool EmptyIndex()
        {
            return tosIndex==0;
        }
        public int getNumEntity()
        {
            return tosId;
        }
        public int getNumIndex()
        {
            return tosIndex;
        }
    }
}
