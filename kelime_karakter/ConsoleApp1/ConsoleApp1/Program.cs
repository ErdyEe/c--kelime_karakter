//Kullanıcı tarafından girilen hangi boyuttaki bir metin için içerisinde ki kelime sayısını ve karakter sayısını bulan kodu yazınız.
//Güncelleme: Eğer birden fazla bosluk varsa!!!

//1---------------------------------------------------------------------------

string kelime;
int kelimeSayisi = 0;
Console.WriteLine("yazınız");
kelime = Console.ReadLine();

if (kelime[0] == ' ' && kelime[1] == ' ') kelimeSayisi--;

for (int i = 0; i < kelime.Length; i++)
{

    if (kelime[i] == ' ')
    {
        kelimeSayisi++;
        if (kelime[i] == ' ' && kelime[i + 1] == ' ')
        {
            kelimeSayisi--;
        }
    }
}
Console.WriteLine($"{kelimeSayisi + 1} kelime \n karakter sayısı : {kelime.Length}");



//2--------------------------------------------------------

//string text =Console.ReadLine();
//int kelimeSayisi = 0;
//int sayac = 0;

//for (int i = 0; i < text.Length; i++)
//{
//	if (text[i]==' ')
//	{
//		if (sayac>0)
//		{
//			kelimeSayisi++;
//			sayac = 0;
//		}
//		else { sayac++; }
//	}
//}
//Console.WriteLine($"{kelimeSayisi + 1} kelime \n karakter sayısı : {text.Length}");


