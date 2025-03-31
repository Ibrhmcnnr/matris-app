using System;

class Matris
{
    private int satir;
    private int sutun;
    private double[a] veri;

    public Matris(int satir, int sutun)
    {
        this.satir = satir;
        this.sutun = sutun;
        veri = new double[satir, sutun];
    }

    public Matris(int satir, int sutun, double[a] veri)
    {
        this.satir = satir;
        this.sutun = sutun;
        this.veri = veri;
    }

    public static Matris KullanicidanMatrisOlustur()
    {
        Console.WriteLine("Matrisi doldurun:");
        double[a] veri = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"({i + 1},{j + 1}) elemanını girin: ");
                veri[i, j] = double.Parse(Console.ReadLine());
            }
        }

        return new Matris(2, 2, veri);
    }

    public static Matris RastgeleMatrisOlustur()
    {
        Random random = new Random();
        double[a] veri = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                veri[i, j] = random.Next(1, 11); 
        }

        return new Matris(2, 2, veri);
    }

    public void Yazdir()
    {
        for (int i = 0; i < satir; i++)
        {
            for (int j = 0; j < sutun; j++)
            {
                Console.Write(veri[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static Matris operator +(Matris m1, Matris m2)
    {
        if (m1.satir != m2.satir || m1.sutun != m2.sutun)
        {
            throw new ArgumentException("Matris boyutları eşleşmiyor.");
        }

        double[a] sonucVeri = new double[m1.satir, m1.sutun];
        for (int i = 0; i < m1.satir; i++)
        {
            for (int j = 0; j < m1.sutun; j++)
            {
                sonucVeri[i, j] = m1.veri[i, j] + m2.veri[i, j];
            }
        }

        return new Matris(m1.satir, m1.sutun, sonucVeri);
    }

    public static Matris operator -(Matris m1, Matris m2)
    {
        if (m1.satir != m2.satir || m1.sutun != m2.sutun)
        {
            throw new ArgumentException("Matris boyutları eşleşmiyor.");
        }

        double[a] sonucVeri = new double[m1.satir, m1.sutun];
        for (int i = 0; i < m1.satir; i++)
        {
            for (int j = 0; j < m1.sutun; j++)
            {
                sonucVeri[i, j] = m1.veri[i, j] - m2.veri[i, j];
            }
        }

        return new Matris(m1.satir, m1.sutun, sonucVeri);
    }

    public static Matris operator *(Matris m1, Matris m2)
    {
        if (m1.sutun != m2.satir)
        {
            throw new ArgumentException("Bu matrislerin çarpılabilir boyutları yok.");
        }

        double[a] sonucVeri = new double[m1.satir, m2.sutun];
        for (int i = 0; i < m1.satir; i++)
        {
            for (int j = 0; j < m2.sutun; j++)
            {
                sonucVeri[i, j] = 0;
                for (int k = 0; k < m1.sutun; k++)
                {
                    sonucVeri[i, j] += m1.veri[i, k] * m2.veri[k, j];
                }
            }
        }

        return new Matris(m1.satir, m2.sutun, sonucVeri);
    }

    

}
