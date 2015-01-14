namespace Mvc4DDD.Data.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc4DDD.Data.Context.Mvc4DDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Mvc4DDD.Data.Context.Mvc4DDDContext context)
        {
            // To run the Seed method: Update-Database -Verbose
            
            /*
             new Company
                {
                    //CompanyId = 0,
                    Name = "",
                    HouseNumber = "",
                    PostalCode = "",
                    City = "",
                    Country = "",
                    XCoord = "",
                    YCoord = "",
                    MainPhone = "",
                    Fax = "",
                    AdditionalPhones = new AdditionalPhonesList(),
                    OpeningHours = "",
                    EmailAddress = "",
                    WWW = "",
                    CategoryCode = "",
                    CategoryName = "",
                    DescriptionEn = "",
                    KeywordsEn = "",
                    TrademarksEn = "",
                } 
             */

            context.Companies.AddOrUpdate(
                p => p.Name,
                new Company
                {
                    //CompanyId = 562282,
                    Name = "FCR Tech OÜ",
                    HouseNumber = "43",
                    PostalCode = "10128",
                    City = "Tallinn",
                    Country = "Harjumaa",
                    XCoord = "59.4323153137747514675688113131635499596",
                    YCoord = "24.7669525502334172963712492571135736701",
                    MainPhone = "3726863031",
                    Fax = "3726863031",
                    AdditionalPhones = "3726863032;3726863033", //new AdditionalPhonesList(new String[] {"3726863032", "3726863033"}),
                    OpeningHours = "",
                    EmailAddress = "info@fcrmedia.com",
                    WWW = "www.fcrmedia.com",
                    CategoryCode = "I079",
                    CategoryName = "Internet services",
                    DescriptionEn = "",
                    KeywordsEn = "",
                    TrademarksEn = "",
                },
                new Company
                {
                    //CompanyId = 307751,
                    Name = "FCR Media AS Lõuna-Eesti esindus",
                    HouseNumber = "14",
                    PostalCode = "51006",
                    City = "Tartu",
                    Country = "Tartumaa",
                    XCoord = "58.3826675582636338477167682793374152118",
                    YCoord = "26.7191358698568014331012868246410968466",
                    MainPhone = "3726300300",
                    Fax = "",
                    AdditionalPhones = "", //new AdditionalPhonesList(),
                    OpeningHours = "",
                    EmailAddress = "",
                    WWW = "",
                    CategoryCode = "I043",
                    CategoryName = "Information services",
                    DescriptionEn = "",
                    KeywordsEn = "",
                    TrademarksEn = "",
                },
                new Company
                {
                    //CompanyId = 552287,
                    Name = "FCR Media AS Lääne-Eesti esindus",
                    HouseNumber = "14",
                    PostalCode = "80010",
                    City = "Pärnu",
                    Country = "Pärnumaa",
                    XCoord = "58.3847052167860884392030167554229419074",
                    YCoord = "24.4990636250825048660200986591429387922",
                    MainPhone = "3726300300",
                    Fax = "",
                    AdditionalPhones = "", //new AdditionalPhonesList(),
                    OpeningHours = "",
                    EmailAddress = "",
                    WWW = "",
                    CategoryCode = "I043",
                    CategoryName = "Information services",
                    DescriptionEn = "",
                    KeywordsEn = "",
                    TrademarksEn = "",
                },
                new Company
                {
                    //CompanyId = 243339,
                    Name = "FCR Media AS",
                    HouseNumber = "29",
                    PostalCode = "10612",
                    City = "Tallinn",
                    Country = "Harjumaa",
                    XCoord = "59.4311528333424403624877054118154660038",
                    YCoord = "24.7216952564514799983550619461310174468",
                    MainPhone = "3726300300",
                    Fax = "3726300301",
                    AdditionalPhones = "", //new AdditionalPhonesList(),
                    OpeningHours = "E: 8:30 - 17:00; T: 8:30 - 17:00; K: 8:30 - 17:00; N: 8:30 - 17:00; R: 8:30 - 17:00",
                    EmailAddress = "info@fcrmedia.ee",
                    WWW = "www.fcrmedia.ee",
                    CategoryCode = "I043",
                    CategoryName = "Information services",
                    DescriptionEn =
                        "FCR Media is one of the leading local search companies in Europe that includes providers of information and " +
                        "advertising services in Estonia, Latvia, Lithuania, Ireland, Czech Republic, Slovakia, Sweden, Russia, Romania," +
                        " Hungary and Finland. The group’s annual revenues are EUR 100 Million and it employs close to 1.300 employees. Total " +
                        "number of business clients amounts to 150.000 in 11 countries. The product range of FCR Media includes web, mobile " +
                        "and print marketing and advertising solutions targeted at small and medium-sized enterprises. In Estonia the group is " +
                        "represented by FCR Media AS, which represents brands like 1182, M-Site, Kontakt, Äri+, delovoi.ee, Estonian Export " +
                        "Directory, Travel Estonia and Outdoor. Among others, FCR Media AS offers a sale service also for the Delfi search " +
                        "engine, Motors24 and is the only official Premium Partner of Google Adwords in Estonia.",
                    KeywordsEn =
                        "information, information services, databases, information catalogues, operator services, hotline, yellow pages, " +
                        "internet catalogues, call center, information search, Estonian information, events, citizen, numbers of individuals, " +
                        "person search, private persons, phone number, company contacts, contacts",
                    TrademarksEn =
                        "1182, Teab ja ühendab, M-Site, KONTAKT, Delovoi.ee, Äri+, TravelEstonia.eu, Estonian Export, Google AdWords, " +
                        "EuroPages, Delfi otsing, Motors24",
                },
                new Company
                {
                    //CompanyId = 552288,
                    Name = "FCR Media AS Ida-Eesti esindus",
                    HouseNumber = "6B",
                    PostalCode = "44310",
                    City = "Rakvere",
                    Country = "Lääne-Virumaa",
                    XCoord = "59.35040898583956689200136953175165984",
                    YCoord = "26.3609186145146721265807248322751935212",
                    MainPhone = "3726300300",
                    Fax = "",
                    AdditionalPhones = "", //new AdditionalPhonesList(),
                    OpeningHours = "E: 8:30 - 17:00; T: 8:30 - 17:00; K: 8:30 - 17:00; N: 8:30 - 17:00; R: 8:30 - 17:00",
                    EmailAddress = "",
                    WWW = "",
                    CategoryCode = "I043",
                    CategoryName = "Information services",
                    DescriptionEn = "",
                    KeywordsEn = "",
                    TrademarksEn = "",
                },
                new Company
                {
                    //CompanyId = 236005,
                    Name = "Kõnekeskuse AS",
                    HouseNumber = "29",
                    PostalCode = "10612",
                    City = "Tallinn",
                    Country = "Harjumaa",
                    XCoord = "59.4311528333424403624877054118154660038",
                    YCoord = "24.7216952564514799983550619461310174468",
                    MainPhone = "3726266560",
                    Fax = "3726300301",
                    AdditionalPhones = "", //new AdditionalPhonesList(),
                    OpeningHours = "E: 8:30 - 17:00; T: 8:30 - 17:00; K: 8:30 - 17:00; N: 8:30 - 17:00; R: 8:30 - 17:00",
                    EmailAddress = "info@callcenter.ee",
                    WWW = "www.callcenter.ee",
                    CategoryCode = "T143",
                    CategoryName = "Telephone services",
                    DescriptionEn = "",
                    KeywordsEn = "",
                    TrademarksEn = "",
                },
                new Company
                {
                    //CompanyId = 532482,
                    Name = "BaltCap AS",
                    HouseNumber = "2",
                    PostalCode = "10145",
                    City = "Tallinn",
                    Country = "Harjumaa",
                    XCoord = "59.4346181140938267052713950287095511456",
                    YCoord = "24.7583870333149733975728470307962864117",
                    MainPhone = "3726650280",
                    Fax = "3726650281",
                    AdditionalPhones = "", //new AdditionalPhonesList(),
                    OpeningHours = "E: 8:30 - 17:00; T: 8:30 - 17:00; K: 8:30 - 17:00; N: 8:30 - 17:00; R: 8:30 - 17:00",
                    EmailAddress = "info@baltcap.com",
                    WWW = "www.baltcap.com",
                    CategoryCode = "I103",
                    CategoryName = "Investment companies",
                    DescriptionEn = "",
                    KeywordsEn = "",
                    TrademarksEn = "",
                }

                );

        }
    }
}
