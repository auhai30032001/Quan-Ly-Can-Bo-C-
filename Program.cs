using System;

namespace QLCB
{

    public interface QLCB
    {
        void NhapQLCB();
        void XuatQLCB();
    }



    class CanBo : QLCB
    {
        protected string name;
        protected string dayOfbirth;
        protected string sex;
        protected string dress;

        public void setter(string a, string b, string c, string d)
        {
            name = a;
            dayOfbirth = b;
            sex = c;
            dress = d;
        }

        public string getname()
        {
            return name;
        }
        public string getday()
        {
            return dayOfbirth;
        }

        public string getdress()
        {
            return dress;
        }

        public string getsex()
        {
            return sex;
        }


        public void NhapQLCB()
        {
            Console.WriteLine("Nhap ten can bo :");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ngay sinh :");
            dayOfbirth = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh :");
            sex = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap dia chi :");
            dress = Convert.ToString(Console.ReadLine());
        }

        public void XuatQLCB()
        {
            Console.WriteLine("Ten can bo : {0}", name);
            Console.WriteLine("Ngay sinh : {0}", dayOfbirth);
            Console.WriteLine("Gioi tinh : {0}", sex);
            Console.WriteLine("Dia chi : {0}", dress);
        }
    }

    class CongNhan : CanBo
    {
        private double Bac;

        public void setbac(double bac)
        {
            Bac = bac;
        }
        public double getBac()
        {
            return Bac;
        }
        public void NhapCongNhan()
        {
            base.NhapQLCB();
            Console.WriteLine("Nhap bac cong nhan : ");
            Bac = Convert.ToDouble(Console.ReadLine());
        }

        public void XuatCongNhan()
        {
            base.XuatQLCB();
            Console.WriteLine("Bac cong nhan : {0}", Bac);
        }

    }

    class KySu : CanBo
    {
        private string NganhDaotao;

        public void setNganh(string nganh)
        {
            NganhDaotao = nganh;
        }

        public string getNganh()
        {
            return NganhDaotao;
        }

        public void NhapKySu()
        {
            base.NhapQLCB();
            Console.WriteLine("Nhap nganh dao tao :");
            NganhDaotao = Convert.ToString(Console.ReadLine());
        }

        public void XuatKySu()
        {
            base.XuatQLCB();
            Console.WriteLine("Nganh dao tao : {0}", NganhDaotao);
        }
    }

    class NhanVien : CanBo
    {
        private string CongViec;

        public void setCv(string cv)
        {
            CongViec = cv;
        }

        public string getCV()
        {
            return CongViec;
        }
        public void NhapNhanVien()
        {
            base.NhapQLCB();
            Console.WriteLine("Nhap cong viec :");
            CongViec = Convert.ToString(Console.ReadLine());
        }
        public void XuatNhanVien()
        {
            base.XuatQLCB();
            Console.WriteLine("Cong viec : {0}", CongViec);
        }
    }


    class QuanLyCanBo
    {
        int n,l,k;
        CongNhan[] congnhan;
        KySu[] kysu;
        NhanVien[] nhanvien;
        public void Input1()
        {
            
            Console.WriteLine("Nhap thong tin cong nhan :");
            Console.WriteLine("Nhap so luong cong nhan :");
            n = Convert.ToInt32(Console.ReadLine());
            congnhan = new CongNhan[n];
            for (int i = 0; i < n; i++)
            {
                congnhan[i] = new CongNhan();
                Console.WriteLine("Thong tin cong nhan thu {0}", i + 1);
                congnhan[i].NhapCongNhan();
            }
        }

        public void Input2()
        {
            
            Console.WriteLine("Nhap thong tin ky su :");
            Console.WriteLine("Nhap so luong ky su :");
            l = Convert.ToInt32(Console.ReadLine());
            kysu = new KySu[l];
            for (int i = 0; i < l; i++)
            {
                kysu[i] = new KySu();
                Console.WriteLine("Thong tin ky su thu {0}", i + 1);
                kysu[i].NhapKySu();
            }
        }

        public void Input3()
        {
            
            Console.WriteLine("Nhap thong tin nhan vien :");
            Console.WriteLine("Nhap so luong nhan vien :");
            k = Convert.ToInt32(Console.ReadLine());
            nhanvien = new NhanVien[k];
            for (int i = 0; i < k; i++)
            {
                nhanvien[i] = new NhanVien();
                Console.WriteLine("Thong tin nhan vien thu {0}", i + 1);
                nhanvien[i].NhapNhanVien();
            }
        }

        public void Output1()
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Thong tin cong nhan {0}:",i+1);
                congnhan[i].XuatCongNhan();
                Console.WriteLine("");
            }
        }

        public void Output2()
        {
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Thong tin ky su  {0}:",i+1);
                kysu[i].XuatKySu();
                Console.WriteLine("");
            }
        }

        public void Output3()
        {
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Thong tin nhan vien {0} :", i+1);
                nhanvien[i].XuatNhanVien();
                Console.WriteLine("");
            }
        }

        public void FindByname1()
        {
            string name;
            int check = 0;
            Console.WriteLine("Nhap ten can tim ");
            name = Convert.ToString(Console.ReadLine());
            for(int i = 0; i < n;i++)
            {
                
                if(congnhan[i].getname().Contains(name))
                {
                    check = 1;
                    congnhan[i].XuatCongNhan();
                }
            }
            if(check == 0)
                {
                Console.WriteLine("Not found");
            }
        }

        public void FindByname2()
        {
            string name2;
            int check = 0;
            Console.WriteLine("Nhap ten can tim ");
            name2 = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {

                if (kysu[i].getname().Contains(name2))
                {
                    check = 1;
                    kysu[i].XuatKySu();
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Not found");
            }
        }

        public void FindByname3()
        {
            string name3;
            int check = 0;
            Console.WriteLine("Nhap ten can tim ");
            name3 = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {

                if (nhanvien[i].getname().Contains(name3))
                {
                    check = 1;
                    nhanvien[i].XuatNhanVien();
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Not found");
            }
        }
        static void Main(string[] args)
        {
            
           /* CongNhan cn = new CongNhan();
            NhanVien nv = new NhanVien();
            KySu ks = new KySu();*/
            QuanLyCanBo q = new QuanLyCanBo();
            while (true)
            {
                Console.WriteLine("1.Nhap thong tin cong nhan ");
                Console.WriteLine("2.Nhap thong tin ky su ");
                Console.WriteLine("3.Nhap thong tin nhan vien ");
                Console.WriteLine("4.Xuat thong tin can bo ");
                Console.WriteLine("5.Tim kiem cong nhan ");
                Console.WriteLine("6.Tim kiem ky su ");
                Console.WriteLine("7.Tim kiem nhan vien ");
                Console.WriteLine("--Bam 0 de thoat chuong trinh ");
                Console.WriteLine("Nhap lua chon ");
                int chose;
                chose = Convert.ToInt32(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        q.Input1();
                        break;
                    case 2:
                        q.Input2();
                        break;
                    case 3:
                        q.Input3();
                        break;
                    case 4:
                        Console.WriteLine("THONG TIN CAC CAN BO \n ");
                        q.Output1();
                        q.Output2();
                        q.Output3();
                        Console.ReadKey();
                        break;
                    case 5:
                        q.FindByname1();
                        break;
                    case 6:
                        q.FindByname2();
                        break;
                    case 7:
                        q.FindByname3();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Vui long chon lai ");
                        break;

                }
                Console.ReadKey();
            }


        }

        }

            }
        
    


