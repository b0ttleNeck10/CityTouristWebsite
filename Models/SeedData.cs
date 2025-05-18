using CityTouristWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace CityTouristWebsite.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.TouristPlaces.Any())
            {
                context.TouristPlaces.AddRange(
                    new TouristPlace
                    {
                        PlaceName = "Mactan Island",
                        Description = "Mactan Island is known for its white sand beaches, luxury resorts, and historical significance as the site of the Battle of Mactan where Lapu-Lapu defeated Ferdinand Magellan.",
                        Tips = "- Visit the iconic Lapu-Lapu Shrine and learn about the legendary battle.\n" +
                                "- Unwind at Mactan Newtown Beach or Maribago Beach.\n" +
                                "- Book a stay at world-class resorts like Shangri-La or Mövenpick.\n" +
                                "- Join an island-hopping tour to nearby islands like Hilutungan or Nalusuan.\n" +
                                "- Try local seafood delicacies at beachfront restaurants.\n" +
                                "- Best Time to Visit: Dry season (March to May)",
                        IframeLink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d156791.4919568827!2d123.86555548224025!3d10.317492266669822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x33a999cdecd5e1e7%3A0x28c7f285bfe26f89!2sMactan+Island!5e0!3m2!1sen!2sph!4v1712543412345!5m2!1sen!2sph",
                        ImagePath = "~/images/places/mactan-island.jpg"
                    },
                    new TouristPlace
                    {
                        PlaceName = "Moalboal",
                        Description = "Moalboal is famous for the daily sardine run and Pescador Island — a world-class diving spot teeming with marine life.",
                        Tips = "-Witness the famous daily sardine run in Moalboal town.\n" +
                                "- Dive or snorkel at Pescador Island, rich in marine biodiversity.\n" +
                                "- Explore Alambijod Canyon for thrilling canyoneering adventures.\n" +
                                "- Enjoy sunset views at White Island (Buhatan).\n" +
                                "- Stay at budget-friendly or upscale beachfront accommodations.\n" +
                                "- Best Time to Visit: Dry season (March to May)",
                        IframeLink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d156791.4919568827!2d123.67973288224025!3d9.947292266669822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x33a993a25a3fcdd1%3A0xc05e95f1c91efce!2sMoalboal!5e0!3m2!1sen!2sph!4v1712543412345!5m2!1sen!2sph",
                        ImagePath = "~/images/places/moalboal.png"
                    },
                    new TouristPlace
                    {
                        PlaceName = "Oslob (Whale Shark Interaction)",
                        Description = "Oslob is one of the few places in the world where you can swim with whale sharks in a controlled environment.",
                        Tips = "- Swim with whale sharks early in the morning (ethical note: consider impact on wildlife).\n" +
                                "- Explore Tañon Strait and enjoy scenic coastal drives.\n" +
                                "- Visit Sumilon Blue Lagoon for snorkeling and relaxation.\n" +
                                "- Sample local delicacies like dried mangoes and seafood.\n" +
                                "- Best Time to Visit: Dry season (March to May)",
                        IframeLink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d156791.4919568827!2d123.73723288224025!3d9.837292266669822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x33a99512cc5355b5%3A0x2df992a2131e7ddc!2sOslob!5e0!3m2!1sen!2sph!4v1712543412345!5m2!1sen!2sph",
                        ImagePath = "~/images/places/oslob.jpg"
                    },
                    new TouristPlace
                    {
                        PlaceName = "Bantayan Island",
                        Description = "Bantayan Island is known for its powdery white sand beaches, especially in Santa Fe. It's a peaceful island getaway ideal for relaxation and sunset viewing.",
                        Tips = "- Lounge at Santa Fe Beach, known for its crystal-clear waters.\n" +
                                "- Rent a bike or scooter to explore the island independently.\n" +
                                "- Try the famous Bantayan lechon (roast pig) — rated among the best in the Philippines.\n" +
                                "- Watch sunset at Andoks Beach Resort or Paradise Beach.\n" +
                                "- Take a boat ride to nearby Virgin Island or Mantalongon.\n" +
                                "- Best Time to Visit: Dry season (March to May)",
                        IframeLink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d156791.4919568827!2d123.68983288224025!3d11.037292266669822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x33a9999e5db32b51%3A0xf535c0d316f49515!2sBantayan+Island!5e0!3m2!1sen!2sph!4v1712543412345!5m2!1sen!2sph",
                        ImagePath = "~/images/places/bantayan.jpg"
                    },
                    new TouristPlace
                    {
                        PlaceName = "Malapascua Island",
                        Description = "Malapascua is a diver’s paradise known for rare thresher shark sightings and vibrant coral reefs. The island also offers serene beaches and a laid-back vibe.",
                        Tips = "- Snorkel or dive to see rare thresher sharks at Monad Shoal.\n" +
                                "- Explore house reefs at resorts like Thirsty Mermaid or Bounty Beach.\n" +
                                "- Walk around Gato Island during low tide.\n" +
                                "- Enjoy quiet sunsets at Logon Beach.\n" +
                                "- Try local dishes like grilled squid and kinilaw (ceviche).\n" +
                                "- Best Time to Visit: Dry season (March to May)",
                        IframeLink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d156791.4919568827!2d124.04833288224025!3d11.337292266669822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x33a98fd12d5f5fff%3A0xd905f3d7a5bfa7e7!2sMalapascua+Island!5e0!3m2!1sen!2sph!4v1712543412345!5m2!1sen!2sph",
                        ImagePath = "~/images/places/malapascua.jpg"
                    },
                    new TouristPlace
                    {
                        PlaceName = "Kawasan Falls (Badian)",
                        Description = "Kawasan Falls is a stunning turquoise waterfall with natural pools perfect for swimming. It's also a popular spot for canyoneering adventures.",
                        Tips = "- Swim in the turquoise waterfalls and natural pools.\n" +
                                "- Join a guided canyoneering tour from Badian town.\n" +
                                "- Hike through lush greenery to reach upper falls.\n" +
                                "- Try banana cue and halo-halo at local stalls.\n" +
                                "- Best Time to Visit: Dry season (March to May)",
                        IframeLink = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d156791.4919568827!2d123.71023288224025!3d9.817292266669822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x33a994f52159ec71%3A0xbcb45500f66925d2!2sKawasan+Falls!5e0!3m2!1sen!2sph!4v1712543412345!5m2!1sen!2sph",
                        ImagePath = "~/images/places/kawasan-falls.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
