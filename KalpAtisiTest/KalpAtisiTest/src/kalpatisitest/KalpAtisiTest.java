
package kalpatisitest;
import java.util.Scanner;
public class KalpAtisiTest {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
       KalpAtisi kisiler[]=new KalpAtisi[10];
       String ad,soyad;
       int gun,ay,yil;
       for(int i=0;i<10;i++)
       {
           System.out.print("Adinizi girin:");
           ad=input.next();
           System.out.print("Soyad:");
           soyad=input.next();
           System.out.print("Dogum günü::");
           gun=input.nextInt();
           System.out.print("dogum ayi:");
           ay=input.nextInt();
           System.out.print("Dogum yili:");
           yil=input.nextInt();
           
           if(gun==0||ay==0||yil==0)
           {
               kisiler[i]=new KalpAtisi(ad,soyad);
               
           }
           else
           {
               kisiler[i]=new KalpAtisi(ad,soyad,gun,ay,yil);
           }
           kisiler[i].setyas(kisiler[i].yasHesapla());
       }
       for(int j=0;j<10;j++)
       {
           System.out.printf(kisiler[j].getadi()+" "+kisiler[j].getsoyadi()+ "="+kisiler[j].yasHesapla()+"-"+kisiler[j].idealKalpAtisi());
       }
    }
    
}
