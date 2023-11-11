using Market_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_APP.Services
{
    internal static class GameService
    {
        private static List<Game> Games = new()
        {
        new()
        {
            Name = "DoTA 2",
            Subtitle = ["MOBA","Multiplayer","Strategy"],
            Icon = "smc_5.png",
            Stars = 5,
            Download = 70.5,
            FullImage = "mask_groupupperdota.png",
            Description = "Dota 2 is a multiplayer online battle arena (MOBA) game which has two teams of five players compete to collectively destroy a large structure defended by the opposing team known as the Ancient, whilst defending their own.",
            AccentColorStart = Color.FromArgb("#353535"),
            AccentColorEnd = Color.FromArgb("#8d9098"),
            Images = new()
            {
                "image_18.png",
                "Image_18.png",
                "Image_18.png"
            }
        },
        new()
        {
            Name = "Venus Vacation Wrapd Low",
            Subtitle = ["Shooter","MMO","RT"],
            Icon = "smc_5.png",
            Stars = 3,
            Download = 70.5,
            FullImage = "smc_5.png",
            Description = "As similar as it is in some ways, however, it is also very different in others.",
            AccentColorStart = Color.FromArgb("#a6393b"),
            AccentColorEnd = Color.FromArgb("#d17f21"),
            Images = new()
            {
                "smc_1.png",
                "smc_2.png",
                "smc_3.png"
            }
        },
        new()
        {
            Name = "Earth",
            Subtitle = ["The cradle of life"],
            Icon = "smc_1.png",
            Stars = 3,
            Download = 70.5,
            FullImage = "smc_1.png",
            Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere.",
            AccentColorStart = Color.FromArgb("#0e3d68"),
            AccentColorEnd = Color.FromArgb("#2e97c7"),
            Images = new()
            {
                "image_18.png",
                "smc_2.png",
                "smc_3.png"
            }
        },
        new()
        {
            Name = "Mars",
            Subtitle = ["The red beauty"],
            Icon = "smc_4.png",
            Stars = 3,
            Download = 70.5,
            FullImage = "smc_4.png",
            Description = "No planet has sparked the imaginations of humans as much as Mars. It may be the reddish color of Mars, or the fact that it can often be easily seen in the night sky, that has caused people to wonder about this close neighbor of ours. Tales of “Martians” invading Earth have been around for well over fifty years. But is it likely that any kind of life really does exist on Mars?",
            AccentColorStart = Color.FromArgb("#a23036"),
            AccentColorEnd = Color.FromArgb("#eb3333"),
            Images = new()
            {
                "smc_1.png",
                "smc_2.png",
                "smc_3.png"
            }
        },
        new()
        {
            Name = "Jupiter",
            Subtitle = ["The gas giant"],
            Icon = "smc_2.png",
            Stars = 3,
            Download = 70.5,
            FullImage = "mask_groupupperdota.png",
            Description = "The planet Jupiter is the first of the gas giant planets. Made mostly of gas, they include Jupiter, Saturn, Uranus, and Neptune.\n\nJupiter is first among the planets in terms of size and mass. Its diameter is 11 times bigger than Earth, and its mass is 2.5 times greater than all the other planets combined. The “Great Red Spot” on Jupiter is actually a raging storm.",
            AccentColorStart = Color.FromArgb("#9d4a40"),
            AccentColorEnd = Color.FromArgb("#cd8026"),
            Images = new()
            {
                "smc_1.png",
                "smc_2.png",
                "smc_3.png"
            }
        },
        new()
        {
            Name = "Saturn",
            Subtitle = ["The ring planet"],
            Icon = "smc_4.png",
            Stars = 3,
            Download = 70.5,
            FullImage = "smc_4.png",
            Description = "Most people know about the rings around Saturn, because they are the brightest and most colorful. These rings are made mainly out of ice particles orbiting the planet. While the rings themselves seem big, the particles are very small, usually no more than 10 feet (3 meters) wide.",
            AccentColorStart = Color.FromArgb("#996237"),
            AccentColorEnd = Color.FromArgb("#c6502f"),
            Images = new()
            {
                "smc_1.png",
                "smc_2.png",
                "smc_3.png"
            }
        },
        new()
        {
            Name = "Uranus",
            Subtitle = ["The cold ball"],
            Icon = "smc_5.png",
            Stars = 3,
            Download = 70.5,
            FullImage = "smc_4.png",
            Description = "Uranus is the first planet so far away from the Earth that it can only be seen with the use of a telescope. When it was first discovered in 1781, scientists didn't know what they had found. As astronomers studied the object more closely, they discovered that it had a circular orbit around the Sun. They had found the seventh planet.",
            AccentColorStart = Color.FromArgb("#9d4a40"),
            AccentColorEnd = Color.FromArgb("#996237"),
            Images = new()
            {
                "smc_1.png",
                "smc_2.png",
                "smc_3.png"
            }
        },
        new()
        {
            Name = "Neptune",
            Subtitle = ["Eighth & fathest-away"],
            Icon = "smc_5.png",
            Stars = 3,
            Download = 70.5,
            FullImage = "smc_4.png",
            Description = "Imagine being so good at math that you could figure out the location of a planet you had never even seen! That is what John C. Adams did in 1843 when he discovered Neptune.",
            AccentColorStart = Color.FromArgb("#0c293d"),
            AccentColorEnd = Color.FromArgb("#26abe0"),
            Images = new()
            {
                "smc_1.png",
                "smc_2.png",
                "smc_3.png"
            }
        }
    };

        public static List<Game> GetAllGames()
            => Games;

        public static Game GetGame(string GameName)
            => Games.Where(_game => _game.Name == GameName).FirstOrDefault();

        public static List<Game> GetFeaturedGames()
        {
            var rnd = new Random();
            var randomizedGames = Games.OrderBy(item => rnd.Next());

            return randomizedGames.Take(5).ToList();
        }


    }
}

