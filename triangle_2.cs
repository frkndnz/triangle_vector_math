using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRİANGLE : MonoBehaviour

{
    public Vector3[] dizi;
    public Vector3[] anoktaları,bnoktaları,cnoktaları;
    private int toplam,toplam1;
    public float[] ilkAaçıları, ilkBaçıları, ilkCaçıları,ücgenalanları;
    public Vector3 a, b, c;
    public float minX = -5.0f, maxX = 5.0f, minY = -5.0f, maxY = 5.0f, minZ = -5.0f, maxZ = 5.0f;
    public float ilkAaçısı, ilkBaçısı, ilkCaçısı,ücgenalan;
    public Vector3 anok,bnok,cnok;
    void Start()
    {
        toplam = 3;
        toplam1 = 20;
        dizi = new Vector3[toplam];
        a = dizi[0] = new Vector3(0, 0, 0);
        b = dizi[1] = new Vector3(0, 0, 0);
        c = dizi[2] = new Vector3(0, 0, 0);
        anoktaları = new Vector3[toplam1];
        bnoktaları = new Vector3[toplam1];
        cnoktaları = new Vector3[toplam1];
        ilkAaçıları = new float[toplam1];
        ilkBaçıları = new float[toplam1];
        ilkCaçıları = new float[toplam1];
        ücgenalanları = new float[toplam1];
        for (int i = 0; i < 3; i++)
        {
            randomtriangle();
             Area();
            ilkAaçıları[i] = ilkAaçısı;
            ilkBaçıları[i] = ilkBaçısı;
            ilkCaçıları[i] = ilkCaçısı;
            ücgenalanları[i] = ücgenalan;
            anoktaları[i] = anok;
            bnoktaları[i] = bnok;
            cnoktaları[i] = cnok;
        }
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(+(i + 1) + ".üçgenin -" + "A noktası =" + anoktaları[i] + "B noktası =" + bnoktaları[i] + "C noktası =" + cnoktaları[i]);
            Debug.Log("rastgele " + +(i + 1) + ".üçgenin açıları " + "A = " + ilkAaçıları[i] + "B = " + ilkBaçıları[i] + "C = " + ilkCaçıları[i]);

            Debug.Log(+(i + 1) + ".üçgen alanı=" + ücgenalanları[i]);

        }

    }

    public void randomtriangle()
    {
        float newaX = Random.Range(minX, maxX);
        float newbX = Random.Range(minX, maxX);
        float newcX = Random.Range(minX, maxX);
        float newaY = Random.Range(minY, maxY);
        float newbY = Random.Range(minY, maxY);
        float newcY = Random.Range(minY, maxY);
        float newaZ = Random.Range(minZ, maxZ);
        float newbZ = Random.Range(minZ, maxZ);
        float newcZ = Random.Range(minZ, maxZ);
        float sonuckl, ku, lu, kos, açı1, carbımkl, sonucmn, mu, nu, açı2, kos2, carbımmn, sonucef, eu, fu, açı3, kos3, carbımef;


        a = new Vector3(newaX, newaY, newaZ);
        b = new Vector3(newbX, newbY, newbZ);
        c = new Vector3(newcX, newcY, newcZ);
        anok = a;
        bnok = b;
        cnok = c;
        Vector3 k = b - a;
        Vector3 l = c - a;
        sonuckl = Vector3.Dot(k, l);
        ku = Vector3.Magnitude(k);
        lu = Vector3.Magnitude(l);
        carbımkl = ku * lu;
        kos = sonuckl / carbımkl;
        açı1 = Mathf.Acos(kos);
        Vector3 m = a - b;
        Vector3 n = c - b;
        sonucmn = Vector3.Dot(m, n);
        mu = Vector3.Magnitude(m);
        nu = Vector3.Magnitude(n);
        carbımmn = mu * nu;
        kos2 = sonucmn / carbımmn;
        açı2 = Mathf.Acos(kos2);
        Vector3 e = a - c;
        Vector3 f = b - c;
        sonucef = Vector3.Dot(e, f);
        eu = Vector3.Magnitude(e);
        fu = Vector3.Magnitude(f);
        carbımef = eu * fu;
        kos3 = sonucef / carbımef;
        açı3 = Mathf.Acos(kos3);
        ilkAaçısı = açı1 * Mathf.Rad2Deg;
        ilkBaçısı = açı2 * Mathf.Rad2Deg;
        ilkCaçısı = açı3 * Mathf.Rad2Deg;
    }
    void Area()
    {
        Vector3 k = b - a;
        Vector3 l = c - a;
        var alan1 = Vector3.Cross(k, l);
        float uzunluk = Vector3.Magnitude(alan1);
        float sonuc = uzunluk / 2;
        ücgenalan = sonuc;
    }
        
}

