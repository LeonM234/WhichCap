namespace WhichCap.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WhichCap.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WhichCap.Context.WhichContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WhichCap.Context.WhichContext";
        }

        protected override void Seed(WhichCap.Context.WhichContext context)
        {
            context.Whiches.AddOrUpdate(i => i.ID,
                new Which
                {
                    ApplicationUserID = "Tommy Dude",
                    Title = "Tennis Shoes",
                    Pic1Url = "http://www.planetshoes.com/mmplanet/Images/5388/5388_322_detail.jpg",
                    Pic2Url = "http://www.dhresource.com/albu_283397515_00-1.0x0/men-s-athletic-shoes-sports-shoes-tennis.jpg",
                    Vote1 = 100,
                    Vote2 = 66,
                    Done = false
                },

                new Which
                {
                    ApplicationUserID = "Jessica Ladywoman",
                    Title = "Car",
                    Pic1Url = "http://cnet2.cbsistatic.com/hub/i/r/2014/10/22/d80fd316-a0fd-45fc-9078-37c347630834/thumbnail/770x433/3afcfb2af573eb0306cabe0703df68ef/2015-porsche-macan-turbo-7340-001.jpg",
                    Pic2Url = "http://www.topgear.nl/image/popup/mercedes-g-63-amg-6x6-full-19052013233049-7709.jpg",
                    Vote1 = 200,
                    Vote2 = 3,
                    Done = false
                },

                new Which
                {
                    ApplicationUserID = "Steve Funnyman",
                    Title = "Joke",
                    Pic1Url = "http://www.bestfunnyjokes4u.com/wp-content/uploads/2013/03/funny-cartoon-joke-2.jpeg",
                    Pic2Url = "http://www.psy.gla.ac.uk/~steve/best/find_x_joke.png",
                    Vote1 = 3,
                    Vote2 = 21,
                    Done = false
                }

                );
        }
    }
}
