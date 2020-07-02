
package kalpatisitest;

import java.util.Calendar;
public class KalpAtisi {
    private String adi;
    private String soyadi;
    private int dgunu;
    private int dayi;
    private int dyili;
    private int yas;
    public KalpAtisi(String adi,String soyadi,int dgunu,int dayi,int dyili)
    {
        this.adi=adi;
        this.soyadi=soyadi;
        this.dgunu=dgunu;
        this.dayi=dayi;
        this.dyili=dyili;
    }
    public KalpAtisi(String adi,String soyadi)
    {
        this.adi=adi;
        this.soyadi=soyadi;
        yas=30;
    }
    public void setadi(String adi)
    {
        this.adi=adi;
    }
    public String getadi()
    {
        return this.adi;
    }
   
    public void setsoyadi(String soyadi)
    {
        this.soyadi=soyadi;
    }
    public String getsoyadi()
    {
        return this.soyadi;
    }
    public void setdgunu(int dgunu)
    {
        this.dgunu=dgunu;
    }
    public int getdgunu()
    {
        return this.dgunu;
    }
    public void setdayi(int dayi)
    {
        this.dayi=dayi;
    }
    public int getdayi()
    {
        return this.dayi;
    }
    public void setdyili(int dyili)
    {
        this.dyili=dyili;
    }
    public int getdyili()
    {
        return this.dyili;
    }
    public void setyas(int yas)
    {
        this.yas=yas;
    }
    public int getyas()
    {
        return this.yas;
    }
    public int yasHesapla()
    {
        if(dgunu==0||dayi==0||dyili==0)
        {
            return this.yas;
        }
        int gun,ay,yil;
        Calendar simdikiZaman=Calendar.getInstance();
        gun=simdikiZaman.get(Calendar.DATE)-this.dgunu;
        ay=simdikiZaman.get(Calendar.MONTH)-this.dayi+1;
        yil=simdikiZaman.get(Calendar.YEAR)-this.dyili;
        
        yas=((yil*12+ay)*30+gun)/(30*12);
        return yas;
    }
    public String idealKalpAtisi()
    {
        double ust,alt,max;
        max=220-yas;
        alt=max*50/100;
        ust=max*85/100;
        return "ideal kalp atis araligi:"+alt+"-"+ust;
    }
}
