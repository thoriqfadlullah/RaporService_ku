using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;

namespace RaporService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlConnectionStringBuilder connStringBuilder;
        public Service1()
        {
            //DBConnect();
            string connstring = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
            conn = new SqlConnection(connstring);
            comm = conn.CreateCommand();
        }

        void DBConnect()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-DK319Q3";
            connStringBuilder.InitialCatalog = "raporku";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        //public DataPesanan GetData(string id)
        //{
        //    DataPesanan dp = new DataPesanan();
        //    SqlCommand sqlCommand = new SqlCommand("select * from pesanan where id = " + id, conn);
        //    conn.Open();
        //    SqlDataReader reader = sqlCommand.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        dp.id = reader["id"].ToString();
        //        dp.pesanan = reader["pesanan"].ToString();
        //        dp.harga = reader["harga"].ToString();
        //    }
        //    conn.Close();
        //    return dp;
        //}

        public List<Admin> GetAdmin()
        {
            //string query = String.Format("Update pesanan set pesanan")
            List<Admin> dp = new List<Admin>();
            SqlCommand cmd = new SqlCommand("select * from admin", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Admin pesan = new Admin();
                pesan.id_admin = reader["ID_Admin"].ToString();
                pesan.uname_admin = reader["Username_adm"].ToString();
                pesan.passw_admin = reader["Password_adm"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<Kelas> GetKelas()
        {
            //string query = String.Format("Update pesanan set pesanan")
            List<Kelas> dp = new List<Kelas>();
            SqlCommand cmd = new SqlCommand("select * from kelas", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kelas pesan = new Kelas();
                pesan.id_kelas = reader["ID_Kelas"].ToString();
                pesan.nama_kelas = reader["Nama_Kelas"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<Mapel> GetMapel()
        {
            //string query = String.Format("Update pesanan set pesanan")
            List<Mapel> dp = new List<Mapel>();
            SqlCommand cmd = new SqlCommand("select * from mapel", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Mapel pesan = new Mapel();
                pesan.id_mapel = reader["ID_Mapel"].ToString();
                pesan.nama_mapel = reader["Nama_Mapel"].ToString();
                pesan.nama_jurusan = reader["Nama_Jurusan"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<Rapot> GetRapot()
        {
            //string query = String.Format("Update pesanan set pesanan")
            List<Rapot> dp = new List<Rapot>();
            SqlCommand cmd = new SqlCommand("select * from rapot", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Rapot pesan = new Rapot();
                pesan.nilai = reader["Nilai"].ToString();
                pesan.semester = reader["Semester"].ToString();
                pesan.id_kelas = reader["ID_kelas"].ToString();
                pesan.id_mapel = reader["ID_mapel"].ToString();
                pesan.id_siswa = reader["ID_siswa"].ToString();
                pesan.id_rapot = reader["ID_rapot"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<Siswa> GetSiswa()
        {
            //string query = String.Format("Update pesanan set pesanan")
            List<Siswa> dp = new List<Siswa>();
            SqlCommand cmd = new SqlCommand("select * from siswa", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Siswa pesan = new Siswa();
                pesan.tempat_lahir = reader["Tempat_lahir"].ToString();
                pesan.tgl_lahir = reader["Tanggal_lahir"].ToString();
                pesan.id_kelas = reader["ID_kelas"].ToString();
                pesan.nama_siswa = reader["Nama_siswa"].ToString();
                pesan.id_siswa = reader["ID_siswa"].ToString();
                pesan.id_walikelas = reader["ID_wali_kelas"].ToString();
                pesan.alamat = reader["Alamat"].ToString();
                pesan.nama_ibu = reader["Nama_Ibu"].ToString();
                pesan.nomor_ortu = reader["Nomor_ortu"].ToString();
                pesan.jenis_kelamin = reader["Jenis_kelamin"].ToString();
                pesan.status_kawin = reader["status_kawin"].ToString();
                pesan.nama_ayah = reader["Nama_ayah"].ToString();
                pesan.nama_agama = reader["Nama_agama"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<WaliKelas> GetWaliKelas()
        {
            //string query = String.Format("Update pesanan set pesanan")
            List<WaliKelas> dp = new List<WaliKelas>();
            SqlCommand cmd = new SqlCommand("select * from walikelas", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                WaliKelas pesan = new WaliKelas();
                pesan.id_walikelas = reader["ID_Wali_Kelas"].ToString();
                pesan.nama_walikelas = reader["Nama_Wali_Kelas"].ToString();
                pesan.uname_walikelas = reader["Username_wk"].ToString();
                pesan.passw_walikelas = reader["Password_wk"].ToString();
                pesan.id_kelas = reader["ID_Kelas"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public Admin LoginAdmin(string id)
        {
            Admin ad = new Admin();
            SqlCommand cmd = new SqlCommand("select * from admin where Username_adm = " + "'"+ id + "'", conn);
            //    SqlCommand sqlCommand = new SqlCommand("select * from pesanan where id = " + id, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ad.id_admin = reader["ID_Admin"].ToString();
                ad.uname_admin = reader["Username_adm"].ToString();
                ad.passw_admin = reader["Password_adm"].ToString();
            }
            conn.Close();
            return ad;


            //SqlCommand cmd = new SqlCommand("insert into admin(ID_Admin,Username_adm,Password_adm) values(" +
            //    "'" + dp.id_admin + "'," +
            //    "'" + dp.uname_admin + "'," +
            //    "'" + dp.passw_admin + "')", conn);
            //try
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    return "Data Berhasil Di Simpan";
            //}
            //catch (Exception ex)
            //{
            //    return "Data Gagal Di Simpan : " + ex;
            //}
        }

        public WaliKelas GetWalikelas(string id)
        {
            WaliKelas ad = new WaliKelas();
            SqlCommand cmd = new SqlCommand("select * from walikelas where Username_wk = " + "'" + id + "'", conn);
            //    SqlCommand sqlCommand = new SqlCommand("select * from pesanan where id = " + id, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ad.id_walikelas = reader["ID_Wali_Kelas"].ToString();
                ad.nama_walikelas = reader["Nama_Wali_Kelas"].ToString();
                ad.uname_walikelas = reader["Username_wk"].ToString();
                ad.passw_walikelas = reader["Password_wk"].ToString();
                ad.id_kelas = reader["ID_Kelas"].ToString();
            }
            conn.Close();
            return ad;
        }

        public List<Siswa> GetKelasSiswa(string id)
        {
            List<Siswa> dp = new List<Siswa>();
            SqlCommand cmd = new SqlCommand("select * from siswa where ID_kelas = " + "'" + id + "'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Siswa pesan = new Siswa();
                pesan.tempat_lahir = reader["Tempat_lahir"].ToString();
                pesan.tgl_lahir = reader["Tanggal_lahir"].ToString();
                pesan.id_kelas = reader["ID_kelas"].ToString();
                pesan.nama_siswa = reader["Nama_siswa"].ToString();
                pesan.id_siswa = reader["ID_siswa"].ToString();
                pesan.id_walikelas = reader["ID_wali_kelas"].ToString();
                pesan.alamat = reader["Alamat"].ToString();
                pesan.nama_ibu = reader["Nama_Ibu"].ToString();
                pesan.nomor_ortu = reader["Nomor_ortu"].ToString();
                pesan.jenis_kelamin = reader["Jenis_kelamin"].ToString();
                pesan.status_kawin = reader["status_kawin"].ToString();
                pesan.nama_ayah = reader["Nama_ayah"].ToString();
                pesan.nama_agama = reader["Nama_agama"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<Rapot> GetNilaiRapot(string id)
        {
            List<Rapot> dp = new List<Rapot>();
            SqlCommand cmd = new SqlCommand("select * from rapot where ID_siswa = " + "'" + id + "'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Rapot pesan = new Rapot();
                pesan.nilai = reader["Nilai"].ToString();
                pesan.semester = reader["Semester"].ToString();
                pesan.id_kelas = reader["ID_kelas"].ToString();
                pesan.id_mapel = reader["ID_mapel"].ToString();
                pesan.id_siswa = reader["ID_siswa"].ToString();
                pesan.id_rapot = reader["ID_rapot"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<Rapot> FilterSemester(string id)
        {
            List<Rapot> dp = new List<Rapot>();
            SqlCommand cmd = new SqlCommand("select * from rapot where Semester = " + "'" + id + "'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Rapot pesan = new Rapot();
                pesan.nilai = reader["Nilai"].ToString();
                pesan.semester = reader["Semester"].ToString();
                pesan.id_kelas = reader["ID_kelas"].ToString();
                pesan.id_mapel = reader["ID_mapel"].ToString();
                pesan.id_siswa = reader["ID_siswa"].ToString();
                pesan.id_rapot = reader["ID_rapot"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<ReportNilaiSiswa> ReportNilaiSiswa(string id)
        {
            List<ReportNilaiSiswa> dp = new List<ReportNilaiSiswa>();
            SqlCommand cmd = new SqlCommand("SELECT Nama_Mapel, Nilai, Semester FROM mapel INNER JOIN rapot ON mapel.ID_Mapel = rapot.ID_mapel where ID_siswa = " + "'" + id + "'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReportNilaiSiswa pesan = new ReportNilaiSiswa();
                pesan.nilai = reader["Nilai"].ToString();
                pesan.semester = reader["Semester"].ToString();
                pesan.nama_mapel = reader["Nama_Mapel"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<ReportNilaiSiswa> FilterSemesterv2(string id, string kelas)
        {
            List<ReportNilaiSiswa> dp = new List<ReportNilaiSiswa>();
            SqlCommand cmd = new SqlCommand("SELECT Nama_Mapel, Nilai, Semester FROM mapel INNER JOIN rapot ON mapel.ID_Mapel = rapot.ID_mapel where Semester = " + "'" + id + "' and ID_kelas = " + "'" + kelas + "'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReportNilaiSiswa pesan = new ReportNilaiSiswa();
                pesan.nilai = reader["Nilai"].ToString();
                pesan.semester = reader["Semester"].ToString();
                pesan.nama_mapel = reader["Nama_Mapel"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public List<Siswa> SearchDataSiswa(string id)
        {
            List<Siswa> dp = new List<Siswa>();
            SqlCommand cmd = new SqlCommand("select * from siswa where Nama_siswa LIKE " + "'" + id + "%'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Siswa pesan = new Siswa();
                pesan.tempat_lahir = reader["Tempat_lahir"].ToString();
                pesan.tgl_lahir = reader["Tanggal_lahir"].ToString();
                pesan.id_kelas = reader["ID_kelas"].ToString();
                pesan.nama_siswa = reader["Nama_siswa"].ToString();
                pesan.id_siswa = reader["ID_siswa"].ToString();
                pesan.id_walikelas = reader["ID_wali_kelas"].ToString();
                pesan.alamat = reader["Alamat"].ToString();
                pesan.nama_ibu = reader["Nama_Ibu"].ToString();
                pesan.nomor_ortu = reader["Nomor_ortu"].ToString();
                pesan.jenis_kelamin = reader["Jenis_kelamin"].ToString();
                pesan.status_kawin = reader["status_kawin"].ToString();
                pesan.nama_ayah = reader["Nama_ayah"].ToString();
                pesan.nama_agama = reader["Nama_agama"].ToString();
                dp.Add(pesan);
            }
            conn.Close();
            return dp;
        }

        public string AddDataKelas(Kelas dp)
        {
            SqlCommand cmd = new SqlCommand("insert into kelas(ID_Kelas,Nama_Kelas) values(" +
                "'" + dp.id_kelas + "'," +
                "'" + dp.nama_kelas + "')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Simpan";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Simpan : " + ex;
            }
        }

        public string AddDataMapel(Mapel dp)
        {
            SqlCommand cmd = new SqlCommand("insert into mapel(ID_Mapel,Nama_Mapel,Nama_Jurusan) values(" +
                "'" + dp.id_mapel + "'," +
                "'" + dp.nama_mapel + "'," +
                "'" + dp.nama_jurusan + "')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Simpan";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Simpan : " + ex;
            }
        }

        public string AddDataRapot(Rapot dp)
        {
            SqlCommand cmd = new SqlCommand("insert into rapot(Nilai,Semester,ID_kelas,ID_mapel,ID_siswa,ID_rapot) values(" +
                "'" + dp.nilai + "'," +
                "'" + dp.semester + "'," +
                "'" + dp.id_kelas + "'," +
                "'" + dp.id_mapel + "'," +
                "'" + dp.id_siswa + "'," +
                "'" + dp.id_rapot + "')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Simpan";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Simpan : " + ex;
            }
        }

        public string AddDataSiswa(Siswa dp)
        {
            SqlCommand cmd = new SqlCommand("insert into siswa(Tempat_lahir,Tanggal_lahir,ID_kelas,Nama_siswa,ID_wali_kelas,Alamat,Nama_Ibu,Nomor_ortu,Jenis_kelamin,status_kawin,Nama_ayah,Nama_agama) values(" +
                "'" + dp.tempat_lahir + "'," +
                "'" + dp.tgl_lahir + "'," +
                "'" + dp.id_kelas + "'," +
                "'" + dp.nama_siswa + "'," +
                "'" + dp.id_walikelas + "'," +
                "'" + dp.alamat + "'," +
                "'" + dp.nama_ibu + "'," +
                "'" + dp.nomor_ortu + "'," +
                "'" + dp.jenis_kelamin + "'," +
                "'" + dp.status_kawin + "'," +
                "'" + dp.nama_ayah + "'," +
                "'" + dp.nama_agama + "')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Simpan";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Simpan : " + ex;
            }
        }

        public string AddDataWaliKelas(WaliKelas dp)
        {
            SqlCommand cmd = new SqlCommand("insert into walikelas(Nama_Wali_Kelas,Username_wk,Password_wk,ID_Kelas) values(" +
                "'" + dp.nama_walikelas + "'," +
                "'" + dp.uname_walikelas + "'," +
                "'" + dp.passw_walikelas + "'," +
                "'" + dp.id_kelas + "')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Simpan";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Simpan : " + ex;
            }
        }

        public string UpdateDataWaliKelas(WaliKelas dp)
        {
            SqlCommand cmd = new SqlCommand("update walikelas set Nama_Wali_Kelas='" + dp.nama_walikelas + "'" +
                ", Username_wk='" + dp.uname_walikelas + "', Password_wk='" + dp.passw_walikelas + "'" +
                ", ID_Kelas='" + dp.id_kelas + "' where ID_Wali_Kelas = " + "'" + dp.id_walikelas +"'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Update";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Update : " + ex;
            }
        }

        public string updatedatasiswa(Siswa dp)
        {
            SqlCommand cmd = new SqlCommand("update siswa set Tempat_lahir='" + dp.tempat_lahir + "'" +
                ", Tanggal_lahir='" + dp.tgl_lahir + "', ID_kelas='" + dp.id_kelas + "', Nama_siswa='" + dp.nama_siswa + "'" +
                ", ID_wali_kelas='" + dp.id_walikelas + "', Alamat='" + dp.alamat + "'" + ", Nama_Ibu='" + dp.nama_ibu + "'" +
                ", Nomor_ortu='" + dp.nomor_ortu + "', Jenis_kelamin='" + dp.jenis_kelamin + "'" + ", status_kawin='" + dp.status_kawin + "'" +
                ", Nama_ayah='" + dp.nama_ayah + "', Nama_agama='" + dp.nama_agama + "'" + " where ID_siswa = " + "'" + dp.id_siswa + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Update";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Update : " + ex;
            }
        }

        public string updateNilaiRapot(Rapot dp)
        {
            SqlCommand cmd = new SqlCommand("update rapot set Nilai='" + dp.nilai + "'" +
                ", Semester='" + dp.semester + "', ID_kelas='" + dp.id_kelas + "', ID_mapel='" + dp.id_mapel + "'" +
                ", ID_siswa='" + dp.id_siswa + "' where ID_rapot = " + "'" + dp.id_rapot + "'" + " and ID_mapel = " + "'" + dp.id_mapel + "'" + " and Semester = " + "'" + dp.semester + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Di Update";
            }
            catch (Exception ex)
            {
                return "Data Gagal Di Update : " + ex;
            }
        }
    }
}
