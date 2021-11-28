using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emlak Uygulamasına Hoşgeldiniz!");
            string[] Sehir = new string[0];
            int[] Kat1 = new int[0];
            int[] Kat2 = new int[0];

            while (true)
            {
                Console.Write("Apartman Ekle(1)-Apartman Listele(2)-Apartman Güncelle(3)-Çıkış(0)");
                char enter = Console.ReadKey().KeyChar;
                if (enter == '1')
                {
                    Console.WriteLine();
                    Console.Write("Şehir yazınız: ");
                    string sehir = Console.ReadLine();
                    Console.Write("Kaç katlı bina: ");
                    int kat1 =Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kaçıncı kat: ");
                    int kat2 = int.Parse(Console.ReadLine());
                    Array.Resize(ref Sehir, Sehir.Length + 1);
                    Array.Resize(ref Kat1, Kat1.Length + 1);
                    Array.Resize(ref Kat2, Kat2.Length + 1);
                    Sehir[Sehir.Length - 1] = sehir;
                    Kat1[Kat1.Length - 1] = kat1;
                    Kat2[Kat2.Length - 1] = kat2;
                }
                else if (enter == '2')
                {
                    Console.WriteLine("");
                    for (int i = 0; i < Sehir.Length; i++)
                    {
                        Console.WriteLine($"Şehir:{Sehir[i]} Kaç Katlı:{Kat1[i]} Kaçıncı Kat:{Kat2[i]}");
                    }
                }
                else if (enter == '3')
                {
                    Console.WriteLine();
                    Console.Write("Güncelleme yapılacak şehri giriniz: ");
                    string sehir = Console.ReadLine();
                    for (int i = 0; i < Sehir.Length; i++)
                    {
                        if (sehir.ToLower() == Sehir[i].ToLower())
                        {
                            Console.WriteLine($"Güncelleme yapılacak Şehir:{Sehir[i]} Kaç Katlı:{Kat1[i]} Kaçıncı Kat:{Kat2[i]}");
                            Console.Write("Güncelleme yapılacak kategoriyi seçiniz: Şehir(1)-Kat Sayısı(2)-Bulunduğu Kat(3)-Hepsi(4)");
                            char enter1 = Console.ReadKey().KeyChar;
                            if (enter1=='1')
                            {
                                Console.WriteLine();
                                Console.Write("Güncel şehri yazınız: ");
                                string GuncelSehir = Console.ReadLine();
                                Sehir[i]=GuncelSehir;
                            }
                            else if (enter1=='2')
                            {
                                Console.WriteLine();
                                Console.Write("Güncel katı yazınız: ");
                                int GuncelKat1 = int.Parse(Console.ReadLine());
                                Kat1[i] = GuncelKat1;

                            }
                            else if (enter1=='3')
                            {
                                Console.WriteLine();
                                Console.Write("Güncel kaçıncı kat olduğunu yazınız: ");
                                int GuncelKat2 = int.Parse(Console.ReadLine());
                                Kat2[i] = GuncelKat2;
                            }
                            else if (enter1=='4')
                            {
                                Console.WriteLine();
                                Console.Write("Güncel şehri gir: ");
                                string GuncelSehir = Console.ReadLine();
                                Console.Write("Güncel katı gir: ");
                                int GuncelKat1 = int.Parse(Console.ReadLine());
                                Console.Write("Güncel kaçıncı kat olduğunu gir: ");
                                int GuncelKat2 = int.Parse(Console.ReadLine());
                                Sehir[i] = GuncelSehir;
                                Kat1[i] = GuncelKat1;
                                Kat2[i] = GuncelKat2;

                            }
                            Console.WriteLine($"Güncellenen şehir:{Sehir[i]} Kat sayısı:{Kat1[i]} İstenilen kat:{Kat2[i]}");
                        }
                    }
                }
                else if (enter == '0')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş!!");
                } 
            }
            Console.ReadLine();
        }
    }
}
