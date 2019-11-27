using System;

namespace Exercise5
{
    public class YurtIciKargo:IKargoCompany
    {
        public void Gonder(Siparis siparis)
        {
            Func.SiparisConsolaYazdir(siparis);
        }
    }
}