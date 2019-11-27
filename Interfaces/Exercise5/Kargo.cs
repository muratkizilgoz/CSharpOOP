using System.Collections.Generic;

namespace Exercise5
{
    public class Kargo
    {
        private readonly IList<IKargoCompany> _kargoCompanies;

        public Kargo()
        {
            _kargoCompanies = new List<IKargoCompany>();
        }

        public void Run(Siparis siparis)
        {
            foreach (var kargoCompany in _kargoCompanies)
            {
                kargoCompany.Gonder(siparis);
            }
        }

        public void KargoSirketiEkle(IKargoCompany kargoCompany)
        {
            _kargoCompanies.Add(kargoCompany);
        }
    }
}