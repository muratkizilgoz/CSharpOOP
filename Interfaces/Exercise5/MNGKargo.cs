using System;

namespace Exercise5
{
    public class MNGKargo:IKargoCompany
    {
        public void Gonder(Siparis siparis)
        {
            Func.SiparisConsolaYazdir(siparis);
        }
    }
}