using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RaporService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //[OperationContract]
        //[WebInvoke(Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json,
        //    RequestFormat = WebMessageFormat.Json,
        //    UriTemplate = "getdata/id={id}"
        //    )]
        //DataPesanan GetData(string id);

        // get data admin
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "dataAdmin")]
        List<Admin> GetAdmin();
        
        // get data kelas
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "dataKelas")]
        List<Kelas> GetKelas();

        // get data mapel
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "dataMapel")]
        List<Mapel> GetMapel();

        // get data rapot
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "dataRapot")]
        List<Rapot> GetRapot();
        
        // get data siswa
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "dataSiswa")]
        List<Siswa> GetSiswa();

        // get data waliKelas
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "dataWaliKelas")]
        List<WaliKelas> GetWaliKelas();

        // add data admin
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "getAdmin/username={id}")]
        Admin LoginAdmin(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "getWalikelas/username={id}")]
        WaliKelas GetWalikelas(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "getKelasSiswa/id={id}")]
        List<Siswa> GetKelasSiswa(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "getNilaiRapot/id={id}")]
        List<Rapot> GetNilaiRapot(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "filterSemester/Semester={id}")]
        List<Rapot> FilterSemester(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "reportNilaiSiswa/ids={id}")]
        List<ReportNilaiSiswa> ReportNilaiSiswa(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "filterSemesterv2/Semester={id}")]
        List<ReportNilaiSiswa> FilterSemesterv2(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "searchDataSiswa/nama={id}")]
        List<Siswa> SearchDataSiswa(string id);

        // add data kelas
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "adddataKelas")]
        string AddDataKelas(Kelas dp);

        // add data mapel
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "adddataMapel")]
        string AddDataMapel(Mapel dp);

        // add data rapot
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "adddataRapot")]
        string AddDataRapot(Rapot dp);

        // add data siswa
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "adddataSiswa")]
        string AddDataSiswa(Siswa dp);

        // add data walikelas
        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "adddataWaliKelas")]
        string AddDataWaliKelas(WaliKelas dp);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "updatedataWaliKelas")]
        string UpdateDataWaliKelas(WaliKelas dp);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "updatedatasiswa")]
        string updatedatasiswa(Siswa dp);

        [OperationContract]
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "updateNilaiRapot")]
        string updateNilaiRapot(Rapot dp);
    }

    [DataContract]
    public class Admin
    {
        [DataMember]
        public string id_admin { get; set; }
        [DataMember]
        public string uname_admin { get; set; }
        [DataMember]
        public string passw_admin { get; set; }
    }

    [DataContract]
    public class Kelas
    {
        [DataMember]
        public string id_kelas { get; set; }
        [DataMember]
        public string nama_kelas { get; set; }
    }

    [DataContract]
    public class Mapel
    {
        [DataMember]
        public string id_mapel { get; set; }
        [DataMember]
        public string nama_mapel { get; set; }
        [DataMember]
        public string nama_jurusan { get; set; }
    }

    [DataContract]
    public class Rapot
    {
        [DataMember]
        public string nilai { get; set; }
        [DataMember]
        public string semester { get; set; }
        [DataMember]
        public string id_kelas { get; set; }
        [DataMember]
        public string id_mapel {get; set;}
        [DataMember]
        public string id_siswa { get; set; }
        [DataMember]
        public string id_rapot { get; set; }
    }

    [DataContract]
    public class Siswa
    {
        [DataMember]
        public string tempat_lahir { get; set; }
        [DataMember]
        public string tgl_lahir { get; set; }
        [DataMember]
        public string id_kelas { get; set; }
        [DataMember]
        public string nama_siswa { get; set; }
        [DataMember]
        public string id_siswa { get; set; }
        [DataMember]
        public string id_walikelas { get; set; }
        [DataMember]
        public string alamat { get; set; }
        [DataMember]
        public string nama_ibu { get; set; }
        [DataMember]
        public string nomor_ortu { get; set; }
        [DataMember]
        public string jenis_kelamin { get; set; }
        [DataMember]
        public string status_kawin { get; set; }
        [DataMember]
        public string nama_ayah { get; set; }
        [DataMember]
        public string nama_agama { get; set; }
    }

    [DataContract]
    public class WaliKelas
    {
        [DataMember]
        public string id_walikelas { get; set; }
        [DataMember]
        public string nama_walikelas { get; set; }
        [DataMember]
        public string uname_walikelas { get; set; }
        [DataMember]
        public string passw_walikelas { get; set; }
        [DataMember]
        public string id_kelas { get; set; }
    }

    [DataContract]
    public class ReportNilaiSiswa
    {
        [DataMember]
        public string nama_mapel { get; set; }
        [DataMember]
        public string nilai { get; set; }
        [DataMember]
        public string semester { get; set; }
    }
}
