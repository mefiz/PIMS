using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PIMS.API.Domain.Entities;

namespace PIMS.API.Data.SchemaConfigurations
{
    public class IslandsSchemaConfiguration : IEntityTypeConfiguration<Island>
    {
        public void Configure(EntityTypeBuilder<Island> builder)
        {
            builder.ToTable("Islands");
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(160);
            builder.Property(p => p.DeletedOn).HasDefaultValue(null);

            builder.HasOne(i => i.Atoll).WithMany(a => a.Islands).HasForeignKey(i => i.AtollId);

            builder.HasData(
                new Island { Id = 1, Name = "Baarah", AtollId = 1},
                new Island { Id = 2, Name = "Dhiddhoo", AtollId = 1 },
                new Island { Id = 3, Name = "Filladhoo", AtollId = 1 },
                new Island { Id = 4, Name = "Hoarafushi", AtollId = 1 },
                new Island { Id = 5, Name = "Ihavandhoo", AtollId = 1 },
                new Island { Id = 6, Name = "Kelaa", AtollId = 1 },
                new Island { Id = 7, Name = "Maarandhoo", AtollId = 1 },
                new Island { Id = 8, Name = "Mulhadhoo", AtollId = 1 },
                new Island { Id = 9, Name = "Muraidhoo", AtollId = 1 },
                new Island { Id = 10, Name = "Thakandhoo", AtollId = 1 },
                new Island { Id = 11, Name = "Thuraakunu", AtollId = 1 },
                new Island { Id = 12, Name = "Uligamu", AtollId = 1 },
                new Island { Id = 13, Name = "Utheemu", AtollId = 1 },
                new Island { Id = 14, Name = "Vashafaru", AtollId = 1 },

                new Island { Id = 15, Name = "Hanimaadhoo", AtollId = 2 },
                new Island { Id = 16, Name = "Finey", AtollId = 2 },
                new Island { Id = 17, Name = "Naivadhoo", AtollId = 2 },
                new Island { Id = 18, Name = "Nolhivaranfaru", AtollId = 2 },
                new Island { Id = 19, Name = "Nellaidhoo", AtollId = 2 },
                new Island { Id = 20, Name = "Nolhivaram", AtollId = 2 },
                new Island { Id = 21, Name = "Kurinbi", AtollId = 2 },
                new Island { Id = 22, Name = "Kulhudhuffushi", AtollId = 2 },
                new Island { Id = 23, Name = "Kumundhoo", AtollId = 2 },
                new Island { Id = 24, Name = "Neykurdnedhoo", AtollId = 2 },
                new Island { Id = 25, Name = "Vaikaradhoo", AtollId = 2 },
                new Island { Id = 26, Name = "Makunudhoo", AtollId = 2 },
                new Island { Id = 27, Name = "Hirimaradhoo", AtollId = 2 },

                new Island { Id = 28, Name = "Bileffahi", AtollId = 3 },
                new Island { Id = 29, Name = "Feevah", AtollId = 3 },
                new Island { Id = 30, Name = "Feydhoo", AtollId = 3 },
                new Island { Id = 31, Name = "Foakaidhoo", AtollId = 3 },
                new Island { Id = 32, Name = "Funadhoo", AtollId = 3 },
                new Island { Id = 33, Name = "Goidhoo", AtollId = 3 },
                new Island { Id = 34, Name = "Kanditheemu", AtollId = 3 },
                new Island { Id = 35, Name = "Komandoo", AtollId = 3 },
                new Island { Id = 36, Name = "Lhaimagu", AtollId = 3 },
                new Island { Id = 37, Name = "Maaungoodhoo", AtollId = 3 },
                new Island { Id = 38, Name = "Maroshi", AtollId = 3 },
                new Island { Id = 39, Name = "Milandhoo", AtollId = 3 },
                new Island { Id = 40, Name = "Narudhoo", AtollId = 3 },
                new Island { Id = 41, Name = "Noomaraa", AtollId = 3 },

                new Island { Id = 42, Name = "Foddhoo", AtollId = 4 },
                new Island { Id = 43, Name = "Henbandhoo", AtollId = 4 },
                new Island { Id = 44, Name = "Holhudhoo", AtollId = 4 },
                new Island { Id = 45, Name = "Kendhikulhudhoo", AtollId = 4 },
                new Island { Id = 46, Name = "Kudafari", AtollId = 4 },
                new Island { Id = 47, Name = "Landhoo", AtollId = 4 },
                new Island { Id = 48, Name = "Lhohi", AtollId = 4 },
                new Island { Id = 49, Name = "Maafaru", AtollId = 4 },
                new Island { Id = 50, Name = "Maalhendhoo", AtollId = 4 },
                new Island { Id = 51, Name = "Magoodhoo", AtollId = 4 },
                new Island { Id = 52, Name = "Manadhoo ", AtollId = 4 },
                new Island { Id = 53, Name = "Miladhoo", AtollId = 4 },
                new Island { Id = 54, Name = "Velidhoo", AtollId = 4 },

                new Island { Id = 55, Name = "Alifushi", AtollId = 5 },
                new Island { Id = 56, Name = "Angolhitheemu", AtollId = 5 },
                new Island { Id = 57, Name = "Fainu", AtollId = 5 },
                new Island { Id = 58, Name = "Hulhudhuffaaru", AtollId = 5 },
                new Island { Id = 59, Name = "Inguraidhoo", AtollId = 5 },
                new Island { Id = 60, Name = "Innamaadhoo", AtollId = 5 },
                new Island { Id = 61, Name = "Dhuvaafaru", AtollId = 5 },
                new Island { Id = 62, Name = "Kinolhas", AtollId = 5 },
                new Island { Id = 63, Name = "Maakurathu", AtollId = 5 },
                new Island { Id = 64, Name = "Maduvvaree", AtollId = 5 },
                new Island { Id = 65, Name = "Meedhoo", AtollId = 5 },
                new Island { Id = 66, Name = "Rasgetheemu", AtollId = 5 },
                new Island { Id = 67, Name = "Rasmaadhoo", AtollId = 5 },
                new Island { Id = 68, Name = "Ungoofaaru", AtollId = 5 },
                new Island { Id = 69, Name = "Vaadhoo", AtollId = 5 },

                new Island { Id = 70, Name = "Dharavandhoo", AtollId = 6 },
                new Island { Id = 71, Name = "Dhonfanu", AtollId = 6 },
                new Island { Id = 72, Name = "Eydhafushi ", AtollId = 6 },
                new Island { Id = 73, Name = "Fehendhoo", AtollId = 6 },
                new Island { Id = 74, Name = "Fulhadhoo", AtollId = 6 },
                new Island { Id = 75, Name = "Goidhoo", AtollId = 6 },
                new Island { Id = 76, Name = "Hithaadhoo", AtollId = 6 },
                new Island { Id = 77, Name = "Kamadhoo", AtollId = 6 },
                new Island { Id = 78, Name = "Kendhoo", AtollId = 6 },
                new Island { Id = 79, Name = "Kihaadhoo", AtollId = 6 },
                new Island { Id = 80, Name = "Kudarikilu", AtollId = 6 },
                new Island { Id = 81, Name = "Maalhos", AtollId = 6 },
                new Island { Id = 82, Name = "Thulhaadhoo", AtollId = 6 },

                new Island { Id = 83, Name = "Hinnavaru", AtollId = 7 },
                new Island { Id = 84, Name = "Kurendhoo", AtollId = 7 },
                new Island { Id = 85, Name = "Maafilaafushi", AtollId = 7 },
                new Island { Id = 86, Name = "Naifaru ", AtollId = 7 },
                new Island { Id = 87, Name = "Olhuvelifushi", AtollId = 7 },

                new Island { Id = 88, Name = "Dhiffushi", AtollId = 8 },
                new Island { Id = 89, Name = "Gaafaru", AtollId = 8 },
                new Island { Id = 90, Name = "Gulhi", AtollId = 8 },
                new Island { Id = 91, Name = "Guraidhoo", AtollId = 8 },
                new Island { Id = 92, Name = "Himmafushi", AtollId = 8 },
                new Island { Id = 93, Name = "Hulhumalé", AtollId = 8 },
                new Island { Id = 94, Name = "Huraa", AtollId = 8 },
                new Island { Id = 95, Name = "Kaashidhoo", AtollId = 8 },
                new Island { Id = 96, Name = "Malé ", AtollId = 8 },
                new Island { Id = 97, Name = "Maafushi ", AtollId = 8 },
                new Island { Id = 98, Name = "Thulusdhoo ", AtollId = 8 },
                new Island { Id = 99, Name = "Vilimalé ", AtollId = 8 },

                new Island { Id = 100, Name = "Bodufolhudhoo", AtollId = 9 },
                new Island { Id = 101, Name = "Feridhoo", AtollId = 9 },
                new Island { Id = 102, Name = "Himandhoo", AtollId = 9 },
                new Island { Id = 103, Name = "Maalhos", AtollId = 9 },
                new Island { Id = 104, Name = "Mathiveri", AtollId = 9 },
                new Island { Id = 105, Name = "Rasdhoo", AtollId = 9 },
                new Island { Id = 106, Name = "Thoddoo", AtollId = 9 },
                new Island { Id = 107, Name = "Ukulhas", AtollId = 9 },
                new Island { Id = 108, Name = "Fesdhoo", AtollId = 9 },

                new Island { Id = 109, Name = "Dhangethi", AtollId = 10 },
                new Island { Id = 110, Name = "Dhiddhoo", AtollId = 10 },
                new Island { Id = 111, Name = "Dhigurah", AtollId = 10 },
                new Island { Id = 112, Name = "Fenfushi", AtollId = 10 },
                new Island { Id = 113, Name = "Haggnaameedhoo", AtollId = 10 },
                new Island { Id = 114, Name = "Kunburudhoo", AtollId = 10 },
                new Island { Id = 115, Name = "Maamingili", AtollId = 10 },
                new Island { Id = 116, Name = "Mahibadhoo ", AtollId = 10 },
                new Island { Id = 117, Name = "Mandhoo", AtollId = 10 },
                new Island { Id = 118, Name = "Omadhoo", AtollId = 10 },

                new Island { Id = 119, Name = "Felidhoo ", AtollId = 11 },
                new Island { Id = 120, Name = "Fulidhoo", AtollId = 11 },
                new Island { Id = 121, Name = "Keyodhoo", AtollId = 11 },
                new Island { Id = 122, Name = "Rakeedhoo", AtollId = 11 },
                new Island { Id = 123, Name = "Thinadhoo", AtollId = 11 },

                new Island { Id = 124, Name = "Boli Mulah", AtollId = 12 },
                new Island { Id = 125, Name = "Dhiggaru", AtollId = 12 },
                new Island { Id = 126, Name = "Kolhufushi", AtollId = 12 },
                new Island { Id = 127, Name = "Madifushi", AtollId = 12 },
                new Island { Id = 128, Name = "Maduvvaree", AtollId = 12 },
                new Island { Id = 129, Name = "Muli ", AtollId = 12 },
                new Island { Id = 130, Name = "Naalaafushi", AtollId = 12 },
                new Island { Id = 131, Name = "Raimmandhoo", AtollId = 12 },
                new Island { Id = 132, Name = "Veyvah", AtollId = 12 },

                new Island { Id = 133, Name = "Bileddhoo", AtollId = 13 },
                new Island { Id = 134, Name = "Dharanboodhoo", AtollId = 13 },
                new Island { Id = 135, Name = "Feeali", AtollId = 13 },
                new Island { Id = 136, Name = "Magoodhoo", AtollId = 13 },
                new Island { Id = 137, Name = "Nilandhoo", AtollId = 13 },

                new Island { Id = 138, Name = "Bandidhoo", AtollId = 14 },
                new Island { Id = 139, Name = "Gemendhoo", AtollId = 14 },
                new Island { Id = 140, Name = "Hulhudheli", AtollId = 14 },
                new Island { Id = 141, Name = "Kudahuvadhoo ", AtollId = 14 },
                new Island { Id = 142, Name = "Maaenboodhoo", AtollId = 14 },
                new Island { Id = 143, Name = "Meedhoo", AtollId = 14 },
                new Island { Id = 144, Name = "Rinbudhoo", AtollId = 14 },
                new Island { Id = 145, Name = "Vaanee", AtollId = 14 },

                new Island { Id = 146, Name = "Burunee", AtollId = 15 },
                new Island { Id = 147, Name = "Vilufushi", AtollId = 15 },
                new Island { Id = 148, Name = "Madifushi", AtollId = 15 },
                new Island { Id = 149, Name = "Dhiyamingili", AtollId = 15 },
                new Island { Id = 150, Name = "Guraidhoo", AtollId = 15 },
                new Island { Id = 151, Name = "Gaadhiffushi", AtollId = 15 },
                new Island { Id = 152, Name = "Thimarafushi", AtollId = 15 },
                new Island { Id = 153, Name = "Veymandoo ", AtollId = 15 },
                new Island { Id = 154, Name = "Kinbidhoo", AtollId = 15 },
                new Island { Id = 155, Name = "Omadhoo", AtollId = 15 },
                new Island { Id = 156, Name = "Hirilandhoo", AtollId = 15 },
                new Island { Id = 157, Name = "Kandoodhoo", AtollId = 15 },
                new Island { Id = 158, Name = "Vandhoo", AtollId = 15 },

                new Island { Id = 159, Name = "Dhanbidhoo", AtollId = 16 },
                new Island { Id = 160, Name = "Fonadhoo ", AtollId = 16 },
                new Island { Id = 161, Name = "Gan", AtollId = 16 },
                new Island { Id = 162, Name = "Hithadhoo", AtollId = 16 },
                new Island { Id = 163, Name = "Isdhoo", AtollId = 16 },
                new Island { Id = 164, Name = "Kunahandhoo", AtollId = 16 },
                new Island { Id = 165, Name = "Maabaidhoo", AtollId = 16 },
                new Island { Id = 166, Name = "Maamendhoo", AtollId = 16 },
                new Island { Id = 167, Name = "Maavah", AtollId = 16 },
                new Island { Id = 168, Name = "Mundoo", AtollId = 16 },

                new Island { Id = 169, Name = "Dhaandhoo", AtollId = 17 },
                new Island { Id = 170, Name = "Dhevvadhoo", AtollId = 17 },
                new Island { Id = 171, Name = "Gemanafushi", AtollId = 17 },
                new Island { Id = 172, Name = "Kanduhulhudhoo", AtollId = 17 },
                new Island { Id = 173, Name = "Kolamaafushi", AtollId = 17 },
                new Island { Id = 174, Name = "Kondey", AtollId = 17 },
                new Island { Id = 175, Name = "Maamendhoo", AtollId = 17 },
                new Island { Id = 176, Name = "Nilandhoo", AtollId = 17 },
                new Island { Id = 177, Name = "Villingili", AtollId = 17 },

                new Island { Id = 178, Name = "Fares-Maathodaa", AtollId = 18 },
                new Island { Id = 179, Name = "Fiyoaree", AtollId = 18 },
                new Island { Id = 180, Name = "Gaddhoo", AtollId = 18 },
                new Island { Id = 181, Name = "Hoandeddhoo", AtollId = 18 },
                new Island { Id = 182, Name = "Madaveli", AtollId = 18 },
                new Island { Id = 183, Name = "Nadellaa", AtollId = 18 },
                new Island { Id = 184, Name = "Rathafandhoo", AtollId = 18 },
                new Island { Id = 185, Name = "Thinadhoo ", AtollId = 18 },
                new Island { Id = 186, Name = "Vaadhoo", AtollId = 18 },

                new Island { Id = 187, Name = "Fuvahmulah", AtollId = 19 },

                new Island { Id = 188, Name = "Hithadhoo ", AtollId = 20 },
                new Island { Id = 189, Name = "Maradhoo", AtollId = 20 },
                new Island { Id = 190, Name = "Maradhoo-Feydhoo ", AtollId = 20 },
                new Island { Id = 191, Name = "Feydhoo", AtollId = 20 },
                new Island { Id = 192, Name = "Hulhudhoo", AtollId = 20 },
                new Island { Id = 193, Name = "Meedhoo", AtollId = 20 }
            );
        }
    }
}