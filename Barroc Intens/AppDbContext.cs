using Barroc_Intens.Classes;
using Barroc_Intens.Maintenance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens
{
    internal class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<MaintenanceAppointment> MaintenanceAppointments { get; set; }
        public DbSet<MaintenanceAppointmentProduct> MaintenanceAppointmentProducts { get; set; }
        public DbSet<PlannedAppointment> PlannedAppointment { get; set; }
        public DbSet<CustomInvoice> CustomInvoices { get; set; }
        public DbSet<CustomInvoiceProduct> CustomInvoiceProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StockStatus> StockStatuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Leasecontract> LeaseContracts { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=barroc_intens;user=root;password=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(
                new Rol { RolId = 1, Name = "Admin", IsManager = 1 },
                new Rol { RolId = 2, Name = "Finance.Head", IsManager = 1 },
                new Rol { RolId = 3, Name = "Finance", IsManager = 2 },
                new Rol { RolId = 4, Name = "Sales.Head", IsManager = 1 },
                new Rol { RolId = 5, Name = "Sales", IsManager = 2 },
                new Rol { RolId = 6, Name = "Inkoop.Head", IsManager = 1 },
                new Rol { RolId = 7, Name = "Inkoop", IsManager = 2 },
                new Rol { RolId = 8, Name = "Maintenance.Head", IsManager = 1 },
                new Rol { RolId = 9, Name = "Mainentance", IsManager = 2 });

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Admin", UserName = "Admin", Password = "123", RolId = 1 },
                new User { UserId = 2, Name = "Finance Head", UserName = "FinanceHead", Password = "123", RolId = 2 },
                new User { UserId = 3, Name = "Finance", UserName = "Finance", Password = "123", RolId = 3 },
                new User { UserId = 4, Name = "Sales Head", UserName = "SalesHead", Password = "123", RolId = 4 },
                new User { UserId = 5, Name = "Sales", UserName = "Sales", Password = "123", RolId = 5 },
                new User { UserId = 6, Name = "Inkoop Head", UserName = "InkoopHead", Password = "123", RolId = 6 },
                new User { UserId = 7, Name = "Inkoop", UserName = "Inkoop", Password = "123", RolId = 7 },
                new User { UserId = 8, Name = "Maintenance Head", UserName = "MaintenanceHead", Password = "123", RolId = 8 },
                new User { UserId = 9, Name = "Mainentance", UserName = "Maintenance", Password = "123", RolId = 9 },

                new User { UserId = 10, Name = "Henk", UserName = "Henk", Password = "123", RolId = 9 },
                new User { UserId = 11, Name = "Piet", UserName = "Piet", Password = "123", RolId = 9 },
                new User { UserId = 12, Name = "Elsa", UserName = "Elsa", Password = "123", RolId = 9 },
                new User { UserId = 13, Name = "Sharon", UserName = "Sharon", Password = "123", RolId = 9 });


            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyId = 1, Name = "Kamba", Phone = "541-299-1029", EmailAddress = "sburbidge0@biglobe.ne.jp", Street = "Vahlen", HouseNumber = "853", City = "Newmarket on Fergus", CountryCode = "IE", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 2, Name = "Tagfeed", Phone = "594-536-9505", EmailAddress = "mwerny1@jiathis.com", Street = "Harbort", HouseNumber = "2188", City = "Borås", CountryCode = "SE", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 3, Name = "Edgepulse", Phone = "884-615-4544", EmailAddress = "ccanniffe2@pen.io", Street = "Susan", HouseNumber = "6", City = "Egbe", CountryCode = "NG", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 4, Name = "Feedmix", Phone = "953-405-2727", EmailAddress = "tgilogly3@skype.com", Street = "Parkside", HouseNumber = "649", City = "Vilkija", CountryCode = "LT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 5, Name = "Twinte", Phone = "755-429-1993", EmailAddress = "aveillard4@google.pl", Street = "Ludington", HouseNumber = "95337", City = "Cravo Norte", CountryCode = "CO", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 6, Name = "Feednation", Phone = "728-863-5174", EmailAddress = "eterbruggen5@soup.io", Street = "Gina", HouseNumber = "6", City = "Del Rosario", CountryCode = "PH", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 7, Name = "Jaxnation", Phone = "749-708-3684", EmailAddress = "afloodgate6@google.nl", Street = "Eastwood", HouseNumber = "82", City = "Terara", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 8, Name = "Riffwire", Phone = "182-948-5805", EmailAddress = "smcconnal7@desdev.cn", Street = "Bellgrove", HouseNumber = "3", City = "Daji", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 9, Name = "Linkbuzz", Phone = "965-347-3671", EmailAddress = "dhandslip8@etsy.com", Street = "Lake View", HouseNumber = "708", City = "Şabāḩ as Sālim", CountryCode = "KW", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 10, Name = "Brainverse", Phone = "867-816-1841", EmailAddress = "fdeverose9@sciencedaily.com", Street = "Shopko", HouseNumber = "1564", City = "Piúma", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 11, Name = "Mudo", Phone = "123-452-4527", EmailAddress = "dbenittia@1und1.de", Street = "Stephen", HouseNumber = "7", City = "Lumbardhi", CountryCode = "XK", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 12, Name = "Vidoo", Phone = "814-504-7852", EmailAddress = "kdobbynb@multiply.com", Street = "Harbort", HouseNumber = "347", City = "Yangcheng", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 13, Name = "Skilith", Phone = "307-829-7620", EmailAddress = "dhayseyc@linkedin.com", Street = "Crowley", HouseNumber = "561", City = "Vol’sk", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 14, Name = "Kwideo", Phone = "856-290-3843", EmailAddress = "krivelesd@apache.org", Street = "Birchwood", HouseNumber = "7", City = "Zeqin", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 15, Name = "Quimm", Phone = "962-344-5054", EmailAddress = "epickine@amazon.co.uk", Street = "Warner", HouseNumber = "274", City = "Blumenau", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 16, Name = "Brainverse", Phone = "626-559-7281", EmailAddress = "dabelwhitef@mail.ru", Street = "Grim", HouseNumber = "0", City = "Veiga", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 17, Name = "Fivespan", Phone = "403-179-6455", EmailAddress = "lleeseg@icq.com", Street = "Mayfield", HouseNumber = "4", City = "Nizhniy Lomov", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 18, Name = "Kwilith", Phone = "552-203-7041", EmailAddress = "afalksh@ovh.net", Street = "Manley", HouseNumber = "773", City = "Petropavlovskaya", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 19, Name = "Dynava", Phone = "700-159-1198", EmailAddress = "fbaylesi@vkontakte.ru", Street = "Paget", HouseNumber = "569", City = "Ust’-Kalmanka", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 20, Name = "Wikizz", Phone = "468-388-3385", EmailAddress = "dpriggj@biglobe.ne.jp", Street = "Loomis", HouseNumber = "29267", City = "Ganlin", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 21, Name = "Buzzbean", Phone = "430-252-5024", EmailAddress = "aholdeyk@sphinn.com", Street = "Melby", HouseNumber = "01", City = "Las Toscas", CountryCode = "AR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 22, Name = "Photobug", Phone = "403-239-4631", EmailAddress = "mmacrannelll@mail.ru", Street = "Melody", HouseNumber = "02", City = "Ad Dilam", CountryCode = "SA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 23, Name = "Quatz", Phone = "992-675-0874", EmailAddress = "cblackslandm@is.gd", Street = "Rutledge", HouseNumber = "34855", City = "Napuro", CountryCode = "PH", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 24, Name = "Gabtune", Phone = "215-747-5220", EmailAddress = "apawelskin@people.com.cn", Street = "Michigan", HouseNumber = "1", City = "Qixingtai", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 25, Name = "Oloo", Phone = "501-938-4754", EmailAddress = "cmancello@china.com.cn", Street = "South", HouseNumber = "41928", City = "Černovice", CountryCode = "CZ", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 26, Name = "Brainverse", Phone = "805-193-0086", EmailAddress = "dpringp@tiny.cc", Street = "Sundown", HouseNumber = "5677", City = "Azua", CountryCode = "DO", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 27, Name = "Topiclounge", Phone = "212-553-4088", EmailAddress = "tduerdenq@china.com.cn", Street = "Glendale", HouseNumber = "2", City = "Vidual", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 28, Name = "Yakijo", Phone = "978-630-4869", EmailAddress = "gstockhillr@utexas.edu", Street = "Bluestem", HouseNumber = "95", City = "Xianghu", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 29, Name = "Mynte", Phone = "214-832-5754", EmailAddress = "sklemts@wiley.com", Street = "Novick", HouseNumber = "482", City = "Tuupovaara", CountryCode = "FI", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 30, Name = "Zoomdog", Phone = "503-838-4159", EmailAddress = "mdenerleyt@foxnews.com", Street = "Kingsford", HouseNumber = "9557", City = "Yuhuazhai", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 31, Name = "Tagfeed", Phone = "708-588-2187", EmailAddress = "jdenneu@cbc.ca", Street = "Jenifer", HouseNumber = "447", City = "Kayunga", CountryCode = "UG", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 32, Name = "Quaxo", Phone = "572-207-3873", EmailAddress = "mclossv@berkeley.edu", Street = "Artisan", HouseNumber = "15", City = "Yacimiento Río Turbio", CountryCode = "AR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 33, Name = "Zoomzone", Phone = "232-674-0984", EmailAddress = "gspybeyw@google.de", Street = "Brentwood", HouseNumber = "38", City = "Reshetikha", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 34, Name = "Meembee", Phone = "489-495-0697", EmailAddress = "sbendtsenx@craigslist.org", Street = "Coleman", HouseNumber = "9", City = "Finiq", CountryCode = "AL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 35, Name = "Zava", Phone = "814-158-4806", EmailAddress = "gstandringy@xing.com", Street = "Granby", HouseNumber = "23265", City = "Bultfontein", CountryCode = "ZA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 36, Name = "Blogtag", Phone = "413-848-2599", EmailAddress = "srowenaz@time.com", Street = "Mariners Cove", HouseNumber = "52318", City = "Springfield", CountryCode = "US", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 37, Name = "Flipstorm", Phone = "923-627-0840", EmailAddress = "jmclenaghan10@trellian.com", Street = "Hooker", HouseNumber = "61239", City = "Matai", CountryCode = "TZ", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 38, Name = "Realbridge", Phone = "136-332-7843", EmailAddress = "mbadgers11@opera.com", Street = "Lerdahl", HouseNumber = "3562", City = "Tríkala", CountryCode = "GR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 39, Name = "Livefish", Phone = "528-775-2714", EmailAddress = "wcote12@who.int", Street = "Golden Leaf", HouseNumber = "8", City = "Smínthi", CountryCode = "GR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 40, Name = "Devbug", Phone = "327-399-5637", EmailAddress = "mkelwaybamber13@senate.gov", Street = "1st", HouseNumber = "80", City = "Tianyi", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 41, Name = "Oyoba", Phone = "458-186-4295", EmailAddress = "agabriel14@vk.com", Street = "Grayhawk", HouseNumber = "4000", City = "Ordynskoye", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 42, Name = "Avamm", Phone = "118-329-2871", EmailAddress = "dfrise15@pbs.org", Street = "Vernon", HouseNumber = "47630", City = "Sunbu", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 43, Name = "Jabberbean", Phone = "989-564-4991", EmailAddress = "wakister16@tamu.edu", Street = "Pierstorff", HouseNumber = "84", City = "Salinópolis", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 44, Name = "Jetwire", Phone = "224-719-7764", EmailAddress = "fwenger17@discuz.net", Street = "Helena", HouseNumber = "0854", City = "Tanshi", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 45, Name = "Oyondu", Phone = "428-931-0522", EmailAddress = "gmactimpany18@uol.com.br", Street = "Paget", HouseNumber = "7", City = "Vale da Pedra", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 46, Name = "Babblestorm", Phone = "306-144-4165", EmailAddress = "sscamadin19@microsoft.com", Street = "Pine View", HouseNumber = "1257", City = "Amor", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 47, Name = "Realpoint", Phone = "411-759-3631", EmailAddress = "zbeedom1a@homestead.com", Street = "Judy", HouseNumber = "54", City = "Krasnyy Profintern", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 48, Name = "Wikivu", Phone = "303-627-0838", EmailAddress = "hbleddon1b@slate.com", Street = "Westerfield", HouseNumber = "82", City = "Lelystad", CountryCode = "NL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 49, Name = "Brainlounge", Phone = "225-507-9239", EmailAddress = "swhiteman1c@icio.us", Street = "Hansons", HouseNumber = "11994", City = "Bobonan", CountryCode = "PH", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 50, Name = "Edgepulse", Phone = "302-312-5156", EmailAddress = "crickaby1d@hubpages.com", Street = "Esker", HouseNumber = "99", City = "Suchy Las", CountryCode = "PL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 51, Name = "Dazzlesphere", Phone = "112-380-3620", EmailAddress = "oleere1e@dedecms.com", Street = "4th", HouseNumber = "6", City = "Heshang", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 52, Name = "Devpulse", Phone = "806-384-7548", EmailAddress = "rrickman1f@phpbb.com", Street = "Declaration", HouseNumber = "5", City = "Pukou", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 53, Name = "Kazu", Phone = "586-236-4440", EmailAddress = "jdeeney1g@jalbum.net", Street = "Fairfield", HouseNumber = "0", City = "Złoczew", CountryCode = "PL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 54, Name = "Myworks", Phone = "256-269-2232", EmailAddress = "dnast1h@va.gov", Street = "Monica", HouseNumber = "9", City = "Huntsville", CountryCode = "US", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 55, Name = "Ntags", Phone = "981-814-4148", EmailAddress = "aferon1i@latimes.com", Street = "Iowa", HouseNumber = "65", City = "Bokino", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 56, Name = "Shuffledrive", Phone = "204-475-2255", EmailAddress = "fclotworthy1j@stanford.edu", Street = "Bunting", HouseNumber = "73517", City = "Thompson", CountryCode = "CA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 57, Name = "Photobean", Phone = "356-106-9005", EmailAddress = "hliddel1k@scribd.com", Street = "Nelson", HouseNumber = "975", City = "Golub-Dobrzyń", CountryCode = "PL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 58, Name = "Devpoint", Phone = "370-574-5375", EmailAddress = "nsapp1l@e-recht24.de", Street = "Summit", HouseNumber = "682", City = "Hokor", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 59, Name = "Voonyx", Phone = "851-473-8565", EmailAddress = "btrownson1m@auda.org.au", Street = "Summerview", HouseNumber = "7239", City = "Jocotán", CountryCode = "GT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 60, Name = "Bubbletube", Phone = "757-546-6151", EmailAddress = "zgiorgeschi1n@yellowbook.com", Street = "Sachtjen", HouseNumber = "94", City = "Jalupang Dua", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 61, Name = "Linkbridge", Phone = "406-132-5929", EmailAddress = "lmather1o@oaic.gov.au", Street = "Colorado", HouseNumber = "007", City = "Fonte Boa", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 62, Name = "Aibox", Phone = "432-764-5720", EmailAddress = "hmathey1p@miitbeian.gov.cn", Street = "Orin", HouseNumber = "96", City = "Shushi", CountryCode = "AZ", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 63, Name = "Reallinks", Phone = "714-264-2253", EmailAddress = "agirtin1q@technorati.com", Street = "Rusk", HouseNumber = "0", City = "Danauparis", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 64, Name = "Meembee", Phone = "501-426-7324", EmailAddress = "glearmonth1r@marriott.com", Street = "Village Green", HouseNumber = "1", City = "Askim", CountryCode = "NO", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 65, Name = "Bubblemix", Phone = "741-174-3595", EmailAddress = "ojanman1s@hp.com", Street = "Stone Corner", HouseNumber = "162", City = "Igaraçu do Tietê", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 66, Name = "Riffwire", Phone = "763-805-2548", EmailAddress = "dbreche1t@chron.com", Street = "Oak Valley", HouseNumber = "227", City = "Dijon", CountryCode = "FR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 67, Name = "Brightbean", Phone = "118-972-6327", EmailAddress = "balchin1u@dailymail.co.uk", Street = "Arizona", HouseNumber = "0257", City = "Toulouse", CountryCode = "FR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 68, Name = "Voomm", Phone = "686-690-2544", EmailAddress = "aroarty1v@t.co", Street = "Tomscot", HouseNumber = "956", City = "Bukid", CountryCode = "PH", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 69, Name = "Demimbu", Phone = "511-741-5663", EmailAddress = "gbelderfield1w@google.co.jp", Street = "Village", HouseNumber = "836", City = "Sungayang", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 70, Name = "Gevee", Phone = "917-939-0986", EmailAddress = "vstirzaker1x@blog.com", Street = "Graceland", HouseNumber = "6", City = "Tamra", CountryCode = "IL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 71, Name = "Yodel", Phone = "334-840-7907", EmailAddress = "tchasen1y@senate.gov", Street = "Jenna", HouseNumber = "492", City = "Oslo", CountryCode = "NO", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 72, Name = "Wikivu", Phone = "237-156-6983", EmailAddress = "mpakes1z@senate.gov", Street = "Loeprich", HouseNumber = "54", City = "Linglong", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 73, Name = "Jaxnation", Phone = "682-857-7809", EmailAddress = "ggregori20@craigslist.org", Street = "Rigney", HouseNumber = "148", City = "Guhua", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 74, Name = "Vimbo", Phone = "649-176-8851", EmailAddress = "edanet21@vimeo.com", Street = "Mifflin", HouseNumber = "4314", City = "Yanglin", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 75, Name = "Realcube", Phone = "557-437-1800", EmailAddress = "tstarkey22@google.de", Street = "North", HouseNumber = "5", City = "Baytīn", CountryCode = "PS", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 76, Name = "Innotype", Phone = "782-199-2374", EmailAddress = "egabb23@boston.com", Street = "Vidon", HouseNumber = "0404", City = "La Esperanza", CountryCode = "MX", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 77, Name = "Blogspan", Phone = "904-246-5451", EmailAddress = "aakerman24@liveinternet.ru", Street = "Onsgard", HouseNumber = "38", City = "Sifangxi", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 78, Name = "Devcast", Phone = "987-328-6453", EmailAddress = "hshard25@latimes.com", Street = "Straubel", HouseNumber = "8", City = "Cigadog", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 79, Name = "Quinu", Phone = "453-191-9425", EmailAddress = "dlamberth26@reverbnation.com", Street = "Raven", HouseNumber = "81926", City = "Göteborg", CountryCode = "SE", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 80, Name = "Jayo", Phone = "118-280-9005", EmailAddress = "obaudesson27@wikia.com", Street = "Tony", HouseNumber = "07138", City = "Noemuti", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 81, Name = "Quinu", Phone = "838-938-0128", EmailAddress = "mlasslett28@latimes.com", Street = "Jenna", HouseNumber = "09563", City = "Ornontowice", CountryCode = "PL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 82, Name = "Skynoodle", Phone = "921-293-5720", EmailAddress = "klarrett29@amazon.com", Street = "Mcguire", HouseNumber = "17633", City = "Xilanqi", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 83, Name = "Flashdog", Phone = "633-175-8037", EmailAddress = "cmityashev2a@shutterfly.com", Street = "Crescent Oaks", HouseNumber = "538", City = "Ribeirinha", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 84, Name = "Topiczoom", Phone = "989-297-8544", EmailAddress = "hluisetti2b@dropbox.com", Street = "Butternut", HouseNumber = "39321", City = "Xiaoqi", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 85, Name = "Eare", Phone = "683-552-6283", EmailAddress = "jcheley2c@sourceforge.net", Street = "Muir", HouseNumber = "6944", City = "Bajiazi", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 86, Name = "Dabfeed", Phone = "629-528-8843", EmailAddress = "galekhov2d@privacy.gov.au", Street = "Mallory", HouseNumber = "247", City = "Yuxi", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 87, Name = "Mynte", Phone = "690-561-2586", EmailAddress = "pgowdie2e@xinhuanet.com", Street = "Meadow Valley", HouseNumber = "66", City = "Lousa", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 88, Name = "Brightbean", Phone = "568-884-1731", EmailAddress = "jlagadu2f@yale.edu", Street = "Anthes", HouseNumber = "31159", City = "Banjarsari", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 89, Name = "Flashspan", Phone = "454-628-7925", EmailAddress = "mhaywood2g@unicef.org", Street = "Dottie", HouseNumber = "571", City = "Dadong", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 90, Name = "Gigaclub", Phone = "623-274-9519", EmailAddress = "msturch2h@bandcamp.com", Street = "Ridgeway", HouseNumber = "4039", City = "Billère", CountryCode = "FR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 91, Name = "Vimbo", Phone = "694-489-3895", EmailAddress = "ecorns2i@upenn.edu", Street = "Granby", HouseNumber = "33", City = "Andop", CountryCode = "PH", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 92, Name = "InnoZ", Phone = "950-268-5478", EmailAddress = "lkendell2j@forbes.com", Street = "Forest", HouseNumber = "36", City = "Bodzentyn", CountryCode = "PL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 93, Name = "Cogidoo", Phone = "319-563-1071", EmailAddress = "ptythacott2k@dailymail.co.uk", Street = "Oriole", HouseNumber = "57", City = "Najiaying", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 94, Name = "Tagpad", Phone = "637-214-7603", EmailAddress = "steek2l@jalbum.net", Street = "Pepper Wood", HouseNumber = "9504", City = "Khōshī", CountryCode = "AF", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 95, Name = "Skiptube", Phone = "729-384-0473", EmailAddress = "sdemangel2m@buzzfeed.com", Street = "Waywood", HouseNumber = "82", City = "Jamundí", CountryCode = "CO", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 96, Name = "Jazzy", Phone = "612-437-1699", EmailAddress = "bswalowe2n@4shared.com", Street = "Manley", HouseNumber = "63", City = "Opatowiec", CountryCode = "PL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 97, Name = "Fadeo", Phone = "422-251-2745", EmailAddress = "rkarpman2o@trellian.com", Street = "Badeau", HouseNumber = "69984", City = "Galamares", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 98, Name = "Bubblebox", Phone = "881-972-2320", EmailAddress = "gcasterou2p@webs.com", Street = "Loftsgordon", HouseNumber = "63240", City = "Mataguži", CountryCode = "ME", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 99, Name = "Zava", Phone = "106-214-7158", EmailAddress = "hkollasch2q@people.com.cn", Street = "Texas", HouseNumber = "2552", City = "Inanwatan", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 100, Name = "Viva", Phone = "366-111-2408", EmailAddress = "rbugdall2r@mtv.com", Street = "Continental", HouseNumber = "1649", City = "Ust’ye", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 101, Name = "Realfire", Phone = "812-693-5405", EmailAddress = "mmcrinn2s@vk.com", Street = "Alpine", HouseNumber = "3", City = "Oepula", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 102, Name = "Centimia", Phone = "986-381-7979", EmailAddress = "ibarlow2t@cbsnews.com", Street = "Linden", HouseNumber = "9693", City = "Solina", CountryCode = "BA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 103, Name = "Feednation", Phone = "586-146-5587", EmailAddress = "rlexa2u@businesswire.com", Street = "Farmco", HouseNumber = "7195", City = "Nikol’sk", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 104, Name = "Jayo", Phone = "753-287-1348", EmailAddress = "wbernardelli2v@samsung.com", Street = "Merchant", HouseNumber = "336", City = "Yermish’", CountryCode = "RU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 105, Name = "Rhyzio", Phone = "571-833-5517", EmailAddress = "ievitts2w@bbc.co.uk", Street = "Sheridan", HouseNumber = "424", City = "Arlington", CountryCode = "US", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 106, Name = "Skippad", Phone = "730-675-2591", EmailAddress = "gseakes2x@msn.com", Street = "Dryden", HouseNumber = "0", City = "Labuhanjambu", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 107, Name = "Rhycero", Phone = "233-642-6507", EmailAddress = "chayland2y@geocities.jp", Street = "Clyde Gallagher", HouseNumber = "11687", City = "Taverny", CountryCode = "FR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 108, Name = "Quaxo", Phone = "357-484-5483", EmailAddress = "gcashen2z@squarespace.com", Street = "Eastlawn", HouseNumber = "2401", City = "Nowy Korczyn", CountryCode = "PL", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 109, Name = "Browsezoom", Phone = "115-913-1553", EmailAddress = "ktreweke30@nih.gov", Street = "Elmside", HouseNumber = "6859", City = "La Viña", CountryCode = "AR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 110, Name = "Flashpoint", Phone = "507-681-7061", EmailAddress = "amoule31@comsenz.com", Street = "Mosinee", HouseNumber = "959", City = "Rochester", CountryCode = "US", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 111, Name = "DabZ", Phone = "102-160-4618", EmailAddress = "pelleton32@opensource.org", Street = "Eggendart", HouseNumber = "4", City = "Sande Vila Nova", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 112, Name = "Topiclounge", Phone = "103-184-8522", EmailAddress = "eiozefovich33@dyndns.org", Street = "Mallard", HouseNumber = "84", City = "Nentón", CountryCode = "GT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 113, Name = "Thoughtworks", Phone = "182-468-7582", EmailAddress = "cevens34@google.com.hk", Street = "Northridge", HouseNumber = "4507", City = "Baokou", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 114, Name = "Skipstorm", Phone = "573-969-5251", EmailAddress = "tpaolucci35@google.it", Street = "Namekagon", HouseNumber = "3472", City = "Jefferson City", CountryCode = "US", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 115, Name = "Meembee", Phone = "497-184-0904", EmailAddress = "hyoslowitz36@netlog.com", Street = "Glacier Hill", HouseNumber = "36", City = "San Andres", CountryCode = "PH", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 116, Name = "Feedbug", Phone = "781-931-7810", EmailAddress = "rbrownscombe37@freewebs.com", Street = "Johnson", HouseNumber = "60120", City = "Furong", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 117, Name = "Twitterwire", Phone = "124-654-5375", EmailAddress = "zwortt38@amazonaws.com", Street = "Londonderry", HouseNumber = "85", City = "Hengshui", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 118, Name = "Skinte", Phone = "226-503-5767", EmailAddress = "dabbati39@oracle.com", Street = "Corscot", HouseNumber = "1", City = "Souq Larb’a al Gharb", CountryCode = "MA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 119, Name = "Ntags", Phone = "626-533-4573", EmailAddress = "bkrammer3a@merriam-webster.com", Street = "Sundown", HouseNumber = "5", City = "San Marcos", CountryCode = "SV", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 120, Name = "Zoomcast", Phone = "857-512-1961", EmailAddress = "panelay3b@un.org", Street = "Chinook", HouseNumber = "7918", City = "Shuangyuan", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 121, Name = "Jabberstorm", Phone = "939-224-4552", EmailAddress = "mjiran3c@hexun.com", Street = "Valley Edge", HouseNumber = "48", City = "Sukumo", CountryCode = "JP", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 122, Name = "Agivu", Phone = "124-838-5937", EmailAddress = "bhenriques3d@phoca.cz", Street = "Shasta", HouseNumber = "2", City = "Jönköping", CountryCode = "SE", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 123, Name = "Zoomzone", Phone = "258-665-0219", EmailAddress = "kcheeseman3e@si.edu", Street = "Utah", HouseNumber = "05590", City = "Přibyslav", CountryCode = "CZ", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 124, Name = "Zazio", Phone = "163-408-2607", EmailAddress = "cchatwood3f@elpais.com", Street = "Amoth", HouseNumber = "452", City = "Satita", CountryCode = "SY", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 125, Name = "Zoomlounge", Phone = "684-145-4251", EmailAddress = "bbracci3g@biblegateway.com", Street = "Manufacturers", HouseNumber = "7772", City = "Puncakwangi", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 126, Name = "Kwimbee", Phone = "770-216-4141", EmailAddress = "nwarboys3h@nih.gov", Street = "Golf Course", HouseNumber = "09318", City = "Geser", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 127, Name = "Meetz", Phone = "203-439-5332", EmailAddress = "cmangam3i@issuu.com", Street = "Quincy", HouseNumber = "11146", City = "Marseille", CountryCode = "FR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 128, Name = "Katz", Phone = "682-217-3134", EmailAddress = "gbowstead3j@digg.com", Street = "Mariners Cove", HouseNumber = "55", City = "Jindu", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 129, Name = "Brainlounge", Phone = "508-114-2652", EmailAddress = "iarmstrong3k@eepurl.com", Street = "Ramsey", HouseNumber = "247", City = "Gubukjero Timuk", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 130, Name = "Meemm", Phone = "951-418-9365", EmailAddress = "dfuge3l@vistaprint.com", Street = "Claremont", HouseNumber = "276", City = "Wufeng", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 131, Name = "Flashdog", Phone = "741-137-0083", EmailAddress = "euccello3m@seesaa.net", Street = "Melrose", HouseNumber = "5930", City = "Ja Ela", CountryCode = "LK", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 132, Name = "Kwilith", Phone = "338-962-6653", EmailAddress = "aberndtsson3n@soup.io", Street = "Oak Valley", HouseNumber = "570", City = "Alberton", CountryCode = "CA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 133, Name = "Tagchat", Phone = "844-744-7580", EmailAddress = "vcarreyette3o@who.int", Street = "Buhler", HouseNumber = "4268", City = "Dumandesa", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 134, Name = "Photolist", Phone = "201-393-6873", EmailAddress = "hlappine3p@jiathis.com", Street = "Packers", HouseNumber = "920", City = "Peixing", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 135, Name = "Devpoint", Phone = "719-279-4723", EmailAddress = "alarner3q@symantec.com", Street = "Russell", HouseNumber = "3813", City = "Jedung", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 136, Name = "Yakitri", Phone = "607-553-3863", EmailAddress = "lscimoni3r@bbc.co.uk", Street = "Mandrake", HouseNumber = "675", City = "Fornos", CountryCode = "PT", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 137, Name = "Meevee", Phone = "857-529-2417", EmailAddress = "aclemett3s@techcrunch.com", Street = "Canary", HouseNumber = "05327", City = "Canggetelo", CountryCode = "ID", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 138, Name = "Miboo", Phone = "353-503-0682", EmailAddress = "ptomkys3t@dell.com", Street = "Clyde Gallagher", HouseNumber = "24", City = "Abreu e Lima", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 139, Name = "Bubbletube", Phone = "394-534-9714", EmailAddress = "plosty3u@europa.eu", Street = "Little Fleur", HouseNumber = "83640", City = "Otterburn Park", CountryCode = "CA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 140, Name = "InnoZ", Phone = "657-192-8258", EmailAddress = "zmaxsted3v@opensource.org", Street = "Roxbury", HouseNumber = "8", City = "San Pedro", CountryCode = "PH", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 141, Name = "Meejo", Phone = "850-722-9775", EmailAddress = "cbrundell3w@arizona.edu", Street = "Ruskin", HouseNumber = "4", City = "Ishqoshim", CountryCode = "TJ", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 142, Name = "Talane", Phone = "336-415-3819", EmailAddress = "bkirby3x@virginia.edu", Street = "Dunning", HouseNumber = "8852", City = "Eqbālīyeh", CountryCode = "IR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 143, Name = "Oyope", Phone = "624-355-1052", EmailAddress = "lantognetti3y@cargocollective.com", Street = "Graedel", HouseNumber = "20", City = "Santa Rita Village", CountryCode = "GU", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 144, Name = "Flashspan", Phone = "358-140-7516", EmailAddress = "aburnhard3z@google.com.au", Street = "Namekagon", HouseNumber = "41032", City = "Catumbela", CountryCode = "AO", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 145, Name = "Wordware", Phone = "387-932-9884", EmailAddress = "dechallier40@qq.com", Street = "Valley Edge", HouseNumber = "2742", City = "Afogados da Ingazeira", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 146, Name = "Meemm", Phone = "717-503-3851", EmailAddress = "mantonoczyk41@icio.us", Street = "Sauthoff", HouseNumber = "5937", City = "Kankan", CountryCode = "GN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 147, Name = "Skalith", Phone = "571-951-5717", EmailAddress = "kmuirhead42@psu.edu", Street = "Knutson", HouseNumber = "62198", City = "Tasovčići", CountryCode = "BA", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 148, Name = "Meetz", Phone = "468-736-3025", EmailAddress = "mjarrold43@jimdo.com", Street = "Surrey", HouseNumber = "5", City = "Istres", CountryCode = "FR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 149, Name = "Yabox", Phone = "168-924-2462", EmailAddress = "aragdale44@twitter.com", Street = "Almo", HouseNumber = "2", City = "Wenxian Chengguanzhen", CountryCode = "CN", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 150, Name = "Dabtype", Phone = "586-106-9920", EmailAddress = "dglynne45@nbcnews.com", Street = "Algoma", HouseNumber = "52", City = "Pirapora do Bom Jesus", CountryCode = "BR", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 151, Name = "Curio", Phone = "0648686105", EmailAddress = "curio@curio.com",Street = "Terheidenseweg", HouseNumber = "350", City = "Breda", CountryCode = "31", IsBkrChecked = true, BkrCheckedAt = DateTime.Now },
                new Company { CompanyId = 152, Name = "Hustllebv", Phone = "0658686185", EmailAddress = "hustlebv@hustle.nl",Street = "Poolseweg", HouseNumber = "50", City = "Tilburg", CountryCode = "31", IsBkrChecked = true, BkrCheckedAt = DateTime.Today.AddDays(-10) },
                new Company { CompanyId = 153, Name = "Jarmo Inc.", Phone = "267-555-0100", EmailAddress = "jarmo@jarmo.nl",Street = "Grove Street", HouseNumber = "204", City = "Hanga Roa", CountryCode = "69", IsBkrChecked = false, BkrCheckedAt = null },
                new Company { CompanyId = 154, Name = "Robbie Rotten corp.", Phone = "06-12345678", EmailAddress = "rotten@robbie.nl",Street = "BillboardStreet", HouseNumber = "1", City = "Lazy Town", CountryCode = "97", IsBkrChecked = false, BkrCheckedAt = null }
                );

            modelBuilder.Entity<Leasecontract>().HasData(
                new Leasecontract { id = 1, CompanyId = 151, BkrChecked = 1, UserId = 1, ProductId = 2, PaymentTerm = "Jaarlijks", CreateDate = DateTime.Today.AddMonths(-1) }, 
                new Leasecontract { id = 2, CompanyId = 152, BkrChecked = 0, UserId = 2, ProductId = 3, PaymentTerm = "Maandelijks", CreateDate = DateTime.Today                 
                });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Automaten", IsEmployeeOnly = 2 },
                new Category { CategoryId = 2, Name = "Koffiebonen", IsEmployeeOnly = 2 },
                new Category { CategoryId = 3, Name = "Onderdelen", IsEmployeeOnly = 1  
                });

            modelBuilder.Entity<CustomInvoice>().HasData(
                new CustomInvoice { CustomInvoiceId=1, CompanyId=152, Date = DateTime.Today.AddDays(20), PricePerHour = 30, Discount = 0, HoursWorked = 10, PaidAt = null, Notes = "Koffiebonen ontbreken nog", PaymentTerm = "Jaarlijks", ProductId = 1 },
                new CustomInvoice { CustomInvoiceId=2, CompanyId=153, Date = DateTime.Today, PricePerHour = 10, Discount = 0, HoursWorked = 4, PaidAt = null, Notes = "BKR is nog niet gechecked", PaymentTerm = "Maandelijks", ProductId = 2 },
                new CustomInvoice { CustomInvoiceId=3, CompanyId=151, Date = DateTime.Today.AddDays(-20), PricePerHour = 20, Discount = 10, HoursWorked = 40, PaidAt = DateTime.Today, Notes = "10 jaar klant", PaymentTerm = "Jaarlijks",ProductId = 3 }
                );

            modelBuilder.Entity<StockStatus>().HasData(
                new StockStatus { StockStatusId = 1, Name = "Uit voorraad" },
                new StockStatus { StockStatusId = 2, Name = "Momenteel leverbaar" },
                new StockStatus { StockStatusId = 3, Name = "Momenteel leverbaar(Bijbesteld)" },
                new StockStatus { StockStatusId = 4, Name = "Besteld" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Barroc Intens Italian Light", Description = "S234FREKT\r\n\r\nLease contract: 499,- excl btw per maand\r\n\r\nInstallatiekosten vast: 289,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Barroc Intens Italian", Description = "S234KNDPF\r\n\r\nLease contract: 599 excl btw\r\n\r\nInstallatiekosten vast: 289,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Barroc Intens Italian Deluxe", Description = "S234NNBMV\r\n\r\nLease contract: 799 excl btw\r\n\r\nInstallatiekosten eenmalig vast: 375,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 4, Name = "Barroc Intens Italian Deluxe Special", Description = "S234MMPLA\r\n\r\nLease contract: 999 excl btw\r\n\r\nInstallatiekosten eenmalig vast: 375,- excl btw.", Brand = "Italian", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 1 },
                new Product { ProductId = 5, Name = "Espresso Beneficio", Description = "S239KLIUP\r\n\r\nEen toegankelijke en zachte koffie. Hij is afkomstig van de Finca El Limoncillo, een weelderige plantage aan de rand van het regenwoud in de Matagalpa regio in Nicaragua.\r\n\r\nPer kg: 21.60 excl btw.", Brand = "Beneficio", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 2 },
                new Product { ProductId = 6, Name = "Yellow Bourbon Brasil", Description = "S239MNKLL\r\n\r\nKoffie van de oorspronkelijke koffiestruik (de Bourbon) met gele koffiebessen. Deze zeldzame koffie heeft de afgelopen 20 jaar steeds meer erkenning gekregen en vele prijzen gewonnen.\r\n\r\nPer kg: 23,20 excl btw.", Brand = "Bourbon Brasil", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 2 },
                new Product { ProductId = 7, Name = "Espresso Roma", Description = "S239IPPSD\r\n\r\nEen Italiaanse espresso met een krachtig karakter en een aromatische afdronk.\r\n\r\nPer kg: 20,80 excl btw.", Brand = "Roma", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 2 },
                new Product { ProductId = 8, Name = "Red Honey Honduras", Description = "S239EVVFS\r\n\r\nDe koffie is geproduceerd volgens de honey-methode. Hierbij wordt de koffieboon in haar vruchtvlees gedroogd, waardoor de zoete fruitsmaak diep in de boon trekt. Dit levert een éxtra zoete koffie op.\r\n\r\nPer kg: 27,80 excl btw.", Brand = "Honduras",
                    AmountInStock = 0,
                    StockStatusId = 1,
                    OrderAmount = 0,
                    CategoryId = 2
                },
                new Product { ProductId = 9, Name = "Rubber (10 mm) ", Description = "10 mm", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 10, Name = "Rubber (14 mm) ", Description = "14 mm", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 11, Name = "Slang", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 12, Name = "Voeding (Elektra)", Description = "Elektra", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 13, Name = "Ontkalker", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 14, Name = "Waterfilter", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 15, Name = "Reservoir sensor", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 16, Name = "Druppelstop", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 17, Name = "Electrische pomp", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 18, Name = "Tandwiel 110mm", Description = "110 mm", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 19, Name = "Tandwiel 70mm", Description = "70 mm", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 20, Name = "Maalmotor", Description = "", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 21, Name = "Zeef", Description = "", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 22, Name = "Reinigingstabletten", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 22, Name = "Reiningsborsteltjes", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 },
                new Product { ProductId = 22, Name = "Ontkalkingspijp", Description = "-", Brand = "-", AmountInStock = 0, StockStatusId = 1, OrderAmount = 0, CategoryId = 3 }
                ); ;

            modelBuilder.Entity<MaintenanceAppointment>().HasData(
                new MaintenanceAppointment { MaintenanceAppointmentId = 1, CompanyId = 151, Remark = "Koffiezet automaat 1 is ontploft", Added = DateTime.Now,  AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = true, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 2, CompanyId = 151, Remark = "Koffiezet automaat 2 is ontploft", Added = DateTime.Now, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 3, CompanyId = 151, Remark = "Koffiezet automaat 3 is de linker tuben kapot", Added = DateTime.Now, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 4, CompanyId = 151, Remark = "Koffiezet automaat 4 is ontploft", Added = DateTime.Now,  AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 5, CompanyId = 152, Remark = "Koffiezet automaat 1 is ontploft", Added = DateTime.Now, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = true, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 6, CompanyId = 152, Remark = "Koffiezet automaat 2 is de linker tuben kapot", Added = DateTime.Now,  AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment { MaintenanceAppointmentId = 7, CompanyId = 153, Remark = "Koffiezet automaat 3 is ontploft", Added = DateTime.Now,  AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null, IsRoutineAppointment = false, },
                new MaintenanceAppointment{ MaintenanceAppointmentId = 8,CompanyId = 154,Remark = "Koffiezet automaat 4 is ontploft",Added = DateTime.Now, AppointmentIsPlanned = false, AssignedEmployee = null, UserId = null,IsRoutineAppointment = false,                
                });

            modelBuilder.Entity<PlannedAppointment>().HasData(
                new PlannedAppointment { PlannedAppointmentId = 1, AppointmentDate = DateTime.Now.Date, AppointmentDuration = "",AppointmentTime = DateTime.Now, AssignedEmployee = "", CompanyId = 151 , UserId = 1
                }); 

        }
    }
}