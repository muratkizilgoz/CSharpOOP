using System;

namespace Exercise5
{
    class Program
    {
        /*Design a workflow engine that takes a workflow object and runs it. A workflow is a series of steps or activities. The workflow engine class should have one method called Run() that takes a workflow, and then iterates over each activity in the workflow and runs it.We want our workflows to be extensible, so we can create new activities without impacting the existing activities */
        static void Main(string[] args)
        {
            var mngSiparis = new Siparis()
            {
                Adres = "asdad sokak",
                AliciAdi = "Dusty",
                SiparisNo = "MNG21321",
                ToplamFiyat = 99.99m
            };

            var yurtIciSiparis = new Siparis()
            {
                Adres = "İzmir",
                SiparisNo = "YI123123",
                AliciAdi = "Dustyy",
                ToplamFiyat = 1
            };

            var kargo = new Kargo();
            kargo.KargoSirketiEkle(new MNGKargo());
            kargo.Run(mngSiparis);

            Console.WriteLine();

            var kargo1 = new Kargo();
            kargo1.KargoSirketiEkle(new YurtIciKargo());
            kargo1.Run(yurtIciSiparis);
        }
    }
}
