using Apv.Models.Master;
using Apv.Models.Setting;
using Apv.Models.Transaksi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apv.ViewModels
{
    public class MainVM
    {
        public Main Main { get; set; }
        public MainDetail MainDetail { get; set; }
    }
    public class AddVM
    {
        public int Id { get; set; }
        public List<KodeSurat> KodeSurat { get; set; }
        public List<MainDetail> Rekanan { get; set; }
        public List<SubJenisPotongan> PPN { get; set; }
        public List<SubJenisPotongan> PPH { get; set; }
        public SubJenisPotongan Denda { get; set; }
        public List<Bank> Bank { get; set; }
    }
    public class TransRekeningVM
    {
        public string NoRek { get; set; }
        public string Nama { get; set; }
        public decimal Nominal { get; set; }
    }
    public class TransVM
    {
        public Trans Trans { get; set; }
        public IEnumerable<MainDetail> MainDetail { get; set; }
        public IEnumerable<TransMainDetail> TransMainDetail { get; set; }
        public IEnumerable<TransMainDetailVM> TransMainDetailVM { get; set; }
        public IEnumerable<TransPengadaan> TransPengadaan { get; set; }
        public TransPotongan TransPotonganMaterai { get; set; }
        public TransPotongan TransPotonganDenda { get; set; }
        public IEnumerable<TransPotongan> TransPotonganPPN { get; set; }
        public IEnumerable<TransPotongan> TransPotonganPPH { get; set; }
        public IEnumerable<TransPotongan> TransPotongan { get; set; }
        public TransRekening TransRekeningMain { get; set; }
        public IEnumerable<TransRekening> TransRekeningDebit { get; set; }
        public IEnumerable<TransRekening> TransRekeningKredit { get; set; }
        public IEnumerable<TransRekening> TransRekening { get; set; }
        public List<TransAttachment> TransAttachment { get; set; }
        public IEnumerable<TransTracking> TransTracking { get; set; }
        public List<SubJenisAttch> SubJenisAttch { get; set; }
        public List<OutputAttch> OutputAttch { get; set; }
    }
    public class TransAttchVM
    {
        public int Id { get; set; }
        public string Nomor { get; set; }
        //public string Nama { get; set; }
        public int Jumlah { get; set; }
        public string Path { get; set; }
        public DateTime DocDate { get; set; }
        public int SubJenisAttchId { get; set; }
        public int OutputAttchId { get; set; }
        public string KeyFile { get; set; }
    }
    public class ContractVM
    {
        public List<Vendor> Vendor { get; set; }
        public List<Bank> Bank { get; set; }
    }
    public class TransViewVM
    {
        public int Id { get; set; }
        public KodeSurat KodeSurat { get; set; }
        public string Nomor { get; set; }
        public string Uraian { get; set; }
        public DateTime DocDate { get; set; }
        public string Prestasi { get; set; }
        public string Termin { get; set; }
        public decimal TotalNominal { get; set; }
        public decimal DetailTotalNominal { get; set; }
        public decimal SisaNominal { get; set; }
        public Status Status { get; set; }
        public Vendor Vendor { get; set; }
        public SubJenisPotongan SubJenisPotongan { get; set; }
        public MainDetail MainDetail { get; set; }
        public bool IsTakeBack { get; set; }
    }
    public class TransMainDetailVM
    {
        public int Id { get; set; }
        public MainDetail MainDetail { get; set; }
        public decimal TotalRealisasi { get; set; }
        public decimal TotalNominal { get; set; }
    }
    public class TransSlipsVM
    {
        public Trans Trans { get; set; }
        public IEnumerable<TransSlip> TransSlip { get; set; }
        public IEnumerable<SettingSlip> SettingSlip { get; set; }
    }
    public class InputSlipVM
    {
        public int Id { get; set; }
        public TransSlip TransSlip { get; set; }
        public IEnumerable<Currency> Currency { get; set; }
        public IEnumerable<Bank> Bank { get; set; }
        public IEnumerable<JenisRekening> JenisRekening { get; set; }
        public IEnumerable<SettingSlip> SettingSlips { get; set; }
        public SettingSlip SettingSlip { get; set; }
    }
    public class FilterList
    {
        public List<KodeSurat> ListKodeSurat { get; set; }
        public List<Status> ListStatus { get; set; }
    }
    public class FilterData
    {
        public DateTime StartCreateDate { get; set; }
        public DateTime EndCreateDate { get; set; }
        public bool OptionCreateDate { get; set; }
        public DateTime StartDocDate { get; set; }
        public DateTime EndDocDate { get; set; }
        public bool OptionDocDate { get; set; }
        public int KodeSurat { get; set; }
        public string Nomor { get; set; }
        public bool OptionNomor { get; set; }
        public int Status { get; set; }
        public bool OptionStatus { get; set; }
    }

    public class LaporanHarianVM
    {
        public string nomor { get; set; }
        public DateTime StartCreateDate { get; set; }
        public DateTime docDate { get; set; }
        public string NoReg { get; set; }
        public IEnumerable<nomorREK> NomorREK { get; set; }
        public string uraian { get; set; }
        public IEnumerable<transMain> TransMainDetail { get; set; }
    }

    public class laporanPPN
    {
        public string nomor { get; set; }
        public DateTime docDate { get; set; }
        public int Nilai { get; set; }
        public decimal Tot { get; set; }
        public decimal Nom { get; set; }
        public IEnumerable<maindetail1> mainDetail1 { get; set; }
        public IEnumerable<attach> attachs { get; set; }
        public string subjenis { get; set; }
        public string ket { get; set; }
        public DateTime docdateS { get; set; }
    }
    public class laporanPPH
    {
        public string nomor { get; set; }
        public DateTime docDate { get; set; }
        public string NPWP { get; set; }
        public string Nama { get; set; }
        public int Nilai { get; set; }
        public decimal Tot { get; set; }
        public decimal Nom { get; set; }
        public string Uraian { get; set; }
        public IEnumerable<maindetail2> mainDetail2 { get; set; }
        public IEnumerable<attach1> attach1 { get; set; }
        public string subjenis { get; set; }
        public string ket { get; set; }
    }

    public class transMain
    {
        public IEnumerable<mainDetail> MainDetail { get; set; }
    }
    public class mainDetail
    {
        public string NomorK { get; set; }
    }

    public class nomorREK
    {
        public string noRek { get; set; }
        public string namaRek { get; set; }
    }
    public class maindetail1
    {
        public string NamaM { get; set; }
        public string NPWP { get; set; }
    }
    public class attach
    {
        public string noFak { get; set; }
        public string docDateA { get; set; }
    }
    public class maindetail2
    {
        public string NamaM { get; set; }
        public string NPWP { get; set; }
    }
    public class attach1
    {
        public string noFak { get; set; }
        public DateTime docDateA { get; set; }
    }
}