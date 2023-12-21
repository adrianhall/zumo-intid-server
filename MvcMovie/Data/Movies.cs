using MvcMovie.Models;

namespace MvcMovie.Data;

public static class Movies
{
    private static int idx = 1;

    public static Movie[] MovieList { get; } =
    [
        new Movie /* 000 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 142,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1994, 10, 14),
            Title = "The Shawshank Redemption",
            Year = 1994
        },
        new Movie /* 001 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 175,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1972, 03, 24),
            Title = "The Godfather",
            Year = 1972
        },
        new Movie /* 002 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 200,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1974, 12, 20),
            Title = "The Godfather: Part II",
            Year = 1974
        },
        new Movie /* 003 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 168,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1994, 10, 14),
            Title = "Pulp Fiction",
            Year = 1994
        },
        new Movie /* 004 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 161,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1967, 12, 29),
            Title = "The Good, the Bad and the Ugly",
            Year = 1966
        },
        new Movie /* 005 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 96,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1957, 4, 10),
            Title = "12 Angry Men",
            Year = 1957
        },
        new Movie /* 006 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 152,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2008, 07, 18),
            Title = "The Dark Knight",
            Year = 2008
        },
        new Movie /* 007 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 195,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1993, 12, 15),
            Title = "Schindler's List",
            Year = 1993
        },
        new Movie /* 008 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 201,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2003, 12, 17),
            Title = "The Lord of the Rings: The Return of the King",
            Year = 2003
        },
        new Movie /* 009 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 139,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1999, 10, 15),
            Title = "Fight Club",
            Year = 1999
        },
        new Movie /* 010 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 127,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1980, 05, 21),
            Title = "Star Wars: Episode V - The Empire Strikes Back",
            Year = 1980
        },
        new Movie /* 011 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 133,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1975, 11, 21),
            Title = "One Flew Over the Cuckoo's Nest",
            Year = 1975
        },
        new Movie /* 012 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 178,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2001, 12, 19),
            Title = "The Lord of the Rings: The Fellowship of the Ring",
            Year = 2001
        },
        new Movie /* 013 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 148,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2010, 07, 16),
            Title = "Inception",
            Year = 2010
        },
        new Movie /* 014 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 146,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1990, 09, 19),
            Title = "Goodfellas",
            Year = 1990
        },
        new Movie /* 015 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 121,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1977, 05, 25),
            Title = "Star Wars",
            Year = 1977
        },
        new Movie /* 016 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 141,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1956, 11, 19),
            Title = "Seven Samurai",
            Year = 1954
        },
        new Movie /* 017 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 136,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1999, 03, 31),
            Title = "The Matrix",
            Year = 1999
        },
        new Movie /* 018 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 142,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(1994, 07, 06),
            Title = "Forrest Gump",
            Year = 1994
        },
        new Movie /* 019 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 130,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2002, 01, 01),
            Title = "City of God",
            Year = 2002
        },
        new Movie /* 020 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 179,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2002, 12, 18),
            Title = "The Lord of the Rings: The Two Towers",
            Year = 2002
        },
        new Movie /* 021 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 175,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(1968, 12, 21),
            Title = "Once Upon a Time in the West",
            Year = 1968
        },
        new Movie /* 022 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 127,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1995, 09, 22),
            Title = "Se7en",
            Year = 1995
        },
        new Movie /* 023 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 118,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1991, 02, 14),
            Title = "The Silence of the Lambs",
            Year = 1991
        },
        new Movie /* 024 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 102,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1943, 01, 23),
            Title = "Casablanca",
            Year = 1942
        },
        new Movie /* 025 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 106,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1995, 08, 16),
            Title = "The Usual Suspects",
            Year = 1995
        },
        new Movie /* 026 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 115,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1981, 06, 12),
            Title = "Raiders of the Lost Ark",
            Year = 1981
        },
        new Movie /* 027 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 112,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1955, 01, 13),
            Title = "Rear Window",
            Year = 1954
        },
        new Movie /* 028 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 109,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1960, 9, 8),
            Title = "Psycho",
            Year = 1960
        },
        new Movie /* 029 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 130,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1947, 01, 06),
            Title = "It's a Wonderful Life",
            Year = 1946
        },
        new Movie /* 030 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 110,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1994, 11, 18),
            Title = "Léon: The Professional",
            Year = 1994
        },
        new Movie /* 031 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 110,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1950, 08, 25),
            Title = "Sunset Blvd.",
            Year = 1950
        },
        new Movie /* 032 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 113,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2000, 10, 11),
            Title = "Memento",
            Year = 2000
        },
        new Movie /* 033 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 165,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2012, 07, 20),
            Title = "The Dark Knight Rises",
            Year = 2012
        },
        new Movie /* 034 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 119,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1999, 02, 12),
            Title = "American History X",
            Year = 1998
        },
        new Movie /* 035 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 153,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1979, 08, 15),
            Title = "Apocalypse Now",
            Year = 1979
        },
        new Movie /* 036 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 152,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1991, 07, 03),
            Title = "Terminator 2: Judgment Day",
            Year = 1991
        },
        new Movie /* 037 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 95,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1964, 01, 29),
            Title = "Dr. Strangelove or: How I Learned to Stop Worrying and Love the Bomb",
            Year = 1964
        },
        new Movie /* 038 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 169,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1998, 07, 24),
            Title = "Saving Private Ryan",
            Year = 1998
        },
        new Movie /* 039 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 117,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1979, 05, 25),
            Title = "Alien",
            Year = 1979
        },
        new Movie /* 040 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 136,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1959, 09, 26),
            Title = "North by Northwest",
            Year = 1959
        },
        new Movie /* 041 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 87,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1931, 03, 07),
            Title = "City Lights",
            Year = 1931
        },
        new Movie /* 042 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 125,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(2001, 07, 20),
            Title = "Spirited Away",
            Year = 2001
        },
        new Movie /* 043 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 119,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1941, 9, 5),
            Title = "Citizen Kane",
            Year = 1941
        },
        new Movie /* 044 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 87,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1936, 02, 25),
            Title = "Modern Times",
            Year = 1936
        },
        new Movie /* 045 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 142,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1980, 05, 23),
            Title = "The Shining",
            Year = 1980
        },
        new Movie /* 046 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 129,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1958, 07, 21),
            Title = "Vertigo",
            Year = 1958
        },
        new Movie /* 047 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 116,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1985, 07, 03),
            Title = "Back to the Future",
            Year = 1985
        },
        new Movie /* 048 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 122,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1999, 10, 01),
            Title = "American Beauty",
            Year = 1999
        },
        new Movie /* 049 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 117,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1931, 08, 30),
            Title = "M",
            Year = 1931
        },
        new Movie /* 050 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 149,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2003, 03, 28),
            Title = "The Pianist",
            Year = 2002
        },
        new Movie /* 051 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 151,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2006, 10, 06),
            Title = "The Departed",
            Year = 2006
        },
        new Movie /* 052 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 113,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1976, 02, 08),
            Title = "Taxi Driver",
            Year = 1976
        },
        new Movie /* 053 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 103,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(2010, 06, 18),
            Title = "Toy Story 3",
            Year = 2010
        },
        new Movie /* 054 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 88,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1957, 10, 25),
            Title = "Paths of Glory",
            Year = 1957
        },
        new Movie /* 055 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 118,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(1999, 02, 12),
            Title = "Life Is Beautiful",
            Year = 1997
        },
        new Movie /* 056 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 107,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1944, 04, 24),
            Title = "Double Indemnity",
            Year = 1944
        },
        new Movie /* 057 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 154,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1986, 07, 18),
            Title = "Aliens",
            Year = 1986
        },
        new Movie /* 058 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 98,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(2008, 06, 27),
            Title = "WALL-E",
            Year = 2008
        },
        new Movie /* 059 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 137,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2006, 03, 23),
            Title = "The Lives of Others",
            Year = 2006
        },
        new Movie /* 060 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 136,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1972, 02, 02),
            Title = "A Clockwork Orange",
            Year = 1971
        },
        new Movie /* 061 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 122,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2001, 04, 24),
            Title = "Amélie",
            Year = 2001
        },
        new Movie /* 062 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 155,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2000, 05, 05),
            Title = "Gladiator",
            Year = 2000
        },
        new Movie /* 063 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 189,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1999, 12, 10),
            Title = "The Green Mile",
            Year = 1999
        },
        new Movie /* 064 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 112,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2011, 11, 02),
            Title = "The Intouchables",
            Year = 2011
        },
        new Movie /* 065 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 227,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1963, 01, 30),
            Title = "Lawrence of Arabia",
            Year = 1962
        },
        new Movie /* 066 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 129,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1963, 03, 16),
            Title = "To Kill a Mockingbird",
            Year = 1962
        },
        new Movie /* 067 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 130,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2006, 10, 20),
            Title = "The Prestige",
            Year = 2006
        },
        new Movie /* 068 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 125,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1941, 3, 7),
            Title = "The Great Dictator",
            Year = 1940
        },
        new Movie /* 069 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 99,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1992, 10, 23),
            Title = "Reservoir Dogs",
            Year = 1992
        },
        new Movie /* 070 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 149,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1982, 02, 10),
            Title = "Das Boot",
            Year = 1981
        },
        new Movie /* 071 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 102,
            Rating = MovieRating.NC17,
            ReleaseDate = new DateOnly(2000, 10, 27),
            Title = "Requiem for a Dream",
            Year = 2000
        },
        new Movie /* 072 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 93,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1949, 08, 31),
            Title = "The Third Man",
            Year = 1949
        },
        new Movie /* 073 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 126,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1948, 01, 24),
            Title = "The Treasure of the Sierra Madre",
            Year = 1948
        },
        new Movie /* 074 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 108,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2004, 03, 19),
            Title = "Eternal Sunshine of the Spotless Mind",
            Year = 2004
        },
        new Movie /* 075 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 155,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1990, 02, 23),
            Title = "Cinema Paradiso",
            Year = 1988
        },
        new Movie /* 076 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 139,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1984, 05, 23),
            Title = "Once Upon a Time in America",
            Year = 1984
        },
        new Movie /* 077 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 130,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1974, 06, 20),
            Title = "Chinatown",
            Year = 1974
        },
        new Movie /* 078 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 138,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1997, 09, 19),
            Title = "L.A. Confidential",
            Year = 1997
        },
        new Movie /* 079 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 89,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(1994, 06, 24),
            Title = "The Lion King",
            Year = 1994
        },
        new Movie /* 080 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 134,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1983, 05, 25),
            Title = "Star Wars: Episode VI - Return of the Jedi",
            Year = 1983
        },
        new Movie /* 081 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 116,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1987, 06, 26),
            Title = "Full Metal Jacket",
            Year = 1987
        },
        new Movie /* 082 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 91,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1975, 05, 25),
            Title = "Monty Python and the Holy Grail",
            Year = 1975
        },
        new Movie /* 083 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 177,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1995, 05, 24),
            Title = "Braveheart",
            Year = 1995
        },
        new Movie /* 084 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 103,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1952, 04, 11),
            Title = "Singin' in the Rain",
            Year = 1952
        },
        new Movie /* 085 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 120,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2003, 11, 21),
            Title = "Oldboy",
            Year = 2003
        },
        new Movie /* 086 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 120,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1959, 03, 29),
            Title = "Some Like It Hot",
            Year = 1959
        },
        new Movie /* 087 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 160,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1984, 09, 19),
            Title = "Amadeus",
            Year = 1984
        },
        new Movie /* 088 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 114,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1927, 03, 13),
            Title = "Metropolis",
            Year = 1927
        },
        new Movie /* 089 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 88,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1951, 12, 26),
            Title = "Rashomon",
            Year = 1950
        },
        new Movie /* 090 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 93,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1949, 12, 13),
            Title = "Bicycle Thieves",
            Year = 1948
        },
        new Movie /* 091 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 141,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1968, 4, 6),
            Title = "2001: A Space Odyssey",
            Year = 1968
        },
        new Movie /* 092 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 131,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1992, 08, 07),
            Title = "Unforgiven",
            Year = 1992
        },
        new Movie /* 093 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 138,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1951, 1, 15),
            Title = "All About Eve",
            Year = 1950
        },
        new Movie /* 094 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 125,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1960, 9, 16),
            Title = "The Apartment",
            Year = 1960
        },
        new Movie /* 095 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 127,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1989, 05, 24),
            Title = "Indiana Jones and the Last Crusade",
            Year = 1989
        },
        new Movie /* 096 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 129,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1974, 01, 10),
            Title = "The Sting",
            Year = 1973
        },
        new Movie /* 097 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 129,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1980, 12, 19),
            Title = "Raging Bull",
            Year = 1980
        },
        new Movie /* 098 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 161,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1957, 12, 14),
            Title = "The Bridge on the River Kwai",
            Year = 1957
        },
        new Movie /* 099 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 131,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1988, 07, 15),
            Title = "Die Hard",
            Year = 1988
        },
        new Movie /* 100 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 116,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1958, 2, 6),
            Title = "Witness for the Prosecution",
            Year = 1957
        },
        new Movie /* 101 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 140,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2005, 06, 15),
            Title = "Batman Begins",
            Year = 2005
        },
        new Movie /* 102 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 123,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2011, 03, 16),
            Title = "A Separation",
            Year = 2011
        },
        new Movie /* 103 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 89,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1988, 04, 16),
            Title = "Grave of the Fireflies",
            Year = 1988
        },
        new Movie /* 104 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 118,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2007, 01, 19),
            Title = "Pan's Labyrinth",
            Year = 2006
        },
        new Movie /* 105 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 156,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2004, 09, 16),
            Title = "Downfall",
            Year = 2004
        },
        new Movie /* 106 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 129,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1939, 10, 19),
            Title = "Mr. Smith Goes to Washington",
            Year = 1939
        },
        new Movie /* 107 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 75,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1961, 09, 13),
            Title = "Yojimbo",
            Year = 1961
        },
        new Movie /* 108 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 172,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1963, 7, 4),
            Title = "The Great Escape",
            Year = 1963
        },
        new Movie /* 109 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 132,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1967, 5, 10),
            Title = "For a Few Dollars More",
            Year = 1965
        },
        new Movie /* 110 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 102,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2001, 01, 19),
            Title = "Snatch.",
            Year = 2000
        },
        new Movie /* 111 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 153,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2009, 08, 21),
            Title = "Inglourious Basterds",
            Year = 2009
        },
        new Movie /* 112 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 108,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1954, 06, 24),
            Title = "On the Waterfront",
            Year = 1954
        },
        new Movie /* 113 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 124,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1980, 10, 10),
            Title = "The Elephant Man",
            Year = 1980
        },
        new Movie /* 114 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 96,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1958, 10, 13),
            Title = "The Seventh Seal",
            Year = 1957
        },
        new Movie /* 115 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 81,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(1995, 11, 22),
            Title = "Toy Story",
            Year = 1995
        },
        new Movie /* 116 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 100,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1941, 10, 18),
            Title = "The Maltese Falcon",
            Year = 1941
        },
        new Movie /* 117 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 170,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1995, 12, 15),
            Title = "Heat",
            Year = 1995
        },
        new Movie /* 118 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 75,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1927, 02, 24),
            Title = "The General",
            Year = 1926
        },
        new Movie /* 119 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 116,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2009, 01, 09),
            Title = "Gran Torino",
            Year = 2008
        },
        new Movie /* 120 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 130,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1940, 04, 12),
            Title = "Rebecca",
            Year = 1940
        },
        new Movie /* 121 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 117,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1982, 06, 25),
            Title = "Blade Runner",
            Year = 1982
        },
        new Movie /* 122 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 143,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2012, 05, 04),
            Title = "The Avengers",
            Year = 2012
        },
        new Movie /* 123 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 91,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1959, 06, 22),
            Title = "Wild Strawberries",
            Year = 1957
        },
        new Movie /* 124 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 98,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1996, 04, 05),
            Title = "Fargo",
            Year = 1996
        },
        new Movie /* 125 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 68,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1921, 2, 6),
            Title = "The Kid",
            Year = 1921
        },
        new Movie /* 126 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 170,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1983, 12, 09),
            Title = "Scarface",
            Year = 1983
        },
        new Movie /* 127 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 108,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(1958, 6, 8),
            Title = "Touch of Evil",
            Year = 1958
        },
        new Movie /* 128 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 117,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1998, 03, 06),
            Title = "The Big Lebowski",
            Year = 1998
        },
        new Movie /* 129 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 162,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1985, 06, 01),
            Title = "Ran",
            Year = 1985
        },
        new Movie /* 130 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 182,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1979, 02, 23),
            Title = "The Deer Hunter",
            Year = 1978
        },
        new Movie /* 131 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 126,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1967, 11, 1),
            Title = "Cool Hand Luke",
            Year = 1967
        },
        new Movie /* 132 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 147,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2005, 04, 01),
            Title = "Sin City",
            Year = 2005
        },
        new Movie /* 133 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 72,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1925, 6, 26),
            Title = "The Gold Rush",
            Year = 1925
        },
        new Movie /* 134 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 101,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1951, 06, 30),
            Title = "Strangers on a Train",
            Year = 1951
        },
        new Movie /* 135 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 105,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1934, 02, 23),
            Title = "It Happened One Night",
            Year = 1934
        },
        new Movie /* 136 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 122,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2007, 11, 21),
            Title = "No Country for Old Men",
            Year = 2007
        },
        new Movie /* 137 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 130,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1975, 06, 20),
            Title = "Jaws",
            Year = 1975
        },
        new Movie /* 138 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 107,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1999, 03, 05),
            Title = "Lock, Stock and Two Smoking Barrels",
            Year = 1998
        },
        new Movie /* 139 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 107,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(1999, 08, 06),
            Title = "The Sixth Sense",
            Year = 1999
        },
        new Movie /* 140 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 121,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2005, 02, 04),
            Title = "Hotel Rwanda",
            Year = 2004
        },
        new Movie /* 141 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 85,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1952, 07, 30),
            Title = "High Noon",
            Year = 1952
        },
        new Movie /* 142 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 120,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1986, 12, 24),
            Title = "Platoon",
            Year = 1986
        },
        new Movie /* 143 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 109,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1982, 06, 25),
            Title = "The Thing",
            Year = 1982
        },
        new Movie /* 144 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 110,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1969, 10, 24),
            Title = "Butch Cassidy and the Sundance Kid",
            Year = 1969
        },
        new Movie /* 145 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 101,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1939, 08, 25),
            Title = "The Wizard of Oz",
            Year = 1939
        },
        new Movie /* 146 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 178,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1995, 11, 22),
            Title = "Casino",
            Year = 1995
        },
        new Movie /* 147 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 94,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1996, 07, 19),
            Title = "Trainspotting",
            Year = 1996
        },
        new Movie /* 148 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 111,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(2003, 10, 10),
            Title = "Kill Bill: Vol. 1",
            Year = 2003
        },
        new Movie /* 149 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 140,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2011, 09, 09),
            Title = "Warrior",
            Year = 2011
        },
        new Movie /* 150 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 93,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1977, 04, 20),
            Title = "Annie Hall",
            Year = 1977
        },
        new Movie /* 151 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 101,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1946, 9, 6),
            Title = "Notorious",
            Year = 1946
        },
        new Movie /* 152 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 129,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2009, 08, 13),
            Title = "The Secret in Their Eyes",
            Year = 2009
        },
        new Movie /* 153 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 238,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(1940, 01, 17),
            Title = "Gone with the Wind",
            Year = 1939
        },
        new Movie /* 154 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 126,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1998, 01, 09),
            Title = "Good Will Hunting",
            Year = 1997
        },
        new Movie /* 155 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 118,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2010, 12, 24),
            Title = "The King's Speech",
            Year = 2010
        },
        new Movie /* 156 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 129,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1940, 03, 15),
            Title = "The Grapes of Wrath",
            Year = 1940
        },
        new Movie /* 157 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 148,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2007, 09, 21),
            Title = "Into the Wild",
            Year = 2007
        },
        new Movie /* 158 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 94,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1979, 08, 17),
            Title = "Life of Brian",
            Year = 1979
        },
        new Movie /* 159 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 100,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(2003, 05, 30),
            Title = "Finding Nemo",
            Year = 2003
        },
        new Movie /* 160 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 132,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2006, 03, 17),
            Title = "V for Vendetta",
            Year = 2005
        },
        new Movie /* 161 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 98,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(2010, 03, 26),
            Title = "How to Train Your Dragon",
            Year = 2010
        },
        new Movie /* 162 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 86,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(1988, 04, 16),
            Title = "My Neighbor Totoro",
            Year = 1988
        },
        new Movie /* 163 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 114,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1946, 08, 31),
            Title = "The Big Sleep",
            Year = 1946
        },
        new Movie /* 164 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 105,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1954, 05, 29),
            Title = "Dial M for Murder",
            Year = 1954
        },
        new Movie /* 165 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 212,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1960, 03, 30),
            Title = "Ben-Hur",
            Year = 1959
        },
        new Movie /* 166 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 107,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1984, 10, 26),
            Title = "The Terminator",
            Year = 1984
        },
        new Movie /* 167 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 121,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1976, 11, 27),
            Title = "Network",
            Year = 1976
        },
        new Movie /* 168 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 132,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2005, 01, 28),
            Title = "Million Dollar Baby",
            Year = 2004
        },
        new Movie /* 169 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 108,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2010, 12, 17),
            Title = "Black Swan",
            Year = 2010
        },
        new Movie /* 170 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 93,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1955, 11, 24),
            Title = "The Night of the Hunter",
            Year = 1955
        },
        new Movie /* 171 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 158,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2008, 01, 25),
            Title = "There Will Be Blood",
            Year = 2007
        },
        new Movie /* 172 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 89,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1986, 08, 08),
            Title = "Stand by Me",
            Year = 1986
        },
        new Movie /* 173 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 113,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2002, 01, 30),
            Title = "Donnie Darko",
            Year = 2001
        },
        new Movie /* 174 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 101,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1993, 02, 12),
            Title = "Groundhog Day",
            Year = 1993
        },
        new Movie /* 175 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 125,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1975, 09, 21),
            Title = "Dog Day Afternoon",
            Year = 1975
        },
        new Movie /* 176 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 129,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1996, 01, 05),
            Title = "Twelve Monkeys",
            Year = 1995
        },
        new Movie /* 177 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 154,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2000, 06, 16),
            Title = "Amores Perros",
            Year = 2000
        },
        new Movie /* 178 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 115,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2007, 08, 03),
            Title = "The Bourne Ultimatum",
            Year = 2007
        },
        new Movie /* 179 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 92,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(2009, 04, 09),
            Title = "Mary and Max",
            Year = 2009
        },
        new Movie /* 180 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 99,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1959, 11, 16),
            Title = "The 400 Blows",
            Year = 1959
        },
        new Movie /* 181 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 83,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1967, 03, 16),
            Title = "Persona",
            Year = 1966
        },
        new Movie /* 182 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 106,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1967, 12, 22),
            Title = "The Graduate",
            Year = 1967
        },
        new Movie /* 183 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 191,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1983, 02, 25),
            Title = "Gandhi",
            Year = 1982
        },
        new Movie /* 184 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 85,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1956, 6, 6),
            Title = "The Killing",
            Year = 1956
        },
        new Movie /* 185 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 119,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(2005, 06, 17),
            Title = "Howl's Moving Castle",
            Year = 2004
        },
        new Movie /* 186 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 100,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2012, 01, 20),
            Title = "The Artist",
            Year = 2011
        },
        new Movie /* 187 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 98,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1987, 09, 25),
            Title = "The Princess Bride",
            Year = 1987
        },
        new Movie /* 188 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 120,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2012, 10, 12),
            Title = "Argo",
            Year = 2012
        },
        new Movie /* 189 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 120,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2009, 01, 23),
            Title = "Slumdog Millionaire",
            Year = 2008
        },
        new Movie /* 190 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 131,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1966, 06, 22),
            Title = "Who's Afraid of Virginia Woolf?",
            Year = 1966
        },
        new Movie /* 191 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 108,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1956, 07, 16),
            Title = "La Strada",
            Year = 1954
        },
        new Movie /* 192 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 126,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1962, 10, 24),
            Title = "The Manchurian Candidate",
            Year = 1962
        },
        new Movie /* 193 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 134,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1961, 09, 25),
            Title = "The Hustler",
            Year = 1961
        },
        new Movie /* 194 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 135,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2002, 01, 04),
            Title = "A Beautiful Mind",
            Year = 2001
        },
        new Movie /* 195 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 145,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1969, 06, 18),
            Title = "The Wild Bunch",
            Year = 1969
        },
        new Movie /* 196 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 119,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1976, 12, 03),
            Title = "Rocky",
            Year = 1976
        },
        new Movie /* 197 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 160,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1959, 9, 1),
            Title = "Anatomy of a Murder",
            Year = 1959
        },
        new Movie /* 198 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 120,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1953, 8, 10),
            Title = "Stalag 17",
            Year = 1953
        },
        new Movie /* 199 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 122,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1974, 03, 16),
            Title = "The Exorcist",
            Year = 1973
        },
        new Movie /* 200 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 138,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1972, 12, 10),
            Title = "Sleuth",
            Year = 1972
        },
        new Movie /* 201 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 80,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1948, 8, 28),
            Title = "Rope",
            Year = 1948
        },
        new Movie /* 202 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 184,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1975, 12, 18),
            Title = "Barry Lyndon",
            Year = 1975
        },
        new Movie /* 203 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 123,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1962, 4, 22),
            Title = "The Man Who Shot Liberty Valance",
            Year = 1962
        },
        new Movie /* 204 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 112,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2009, 08, 14),
            Title = "District 9",
            Year = 2009
        },
        new Movie /* 205 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 163,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1980, 04, 17),
            Title = "Stalker",
            Year = 1979
        },
        new Movie /* 206 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 101,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2002, 12, 12),
            Title = "Infernal Affairs",
            Year = 2002
        },
        new Movie /* 207 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 118,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1953, 9, 2),
            Title = "Roman Holiday",
            Year = 1953
        },
        new Movie /* 208 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 103,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1998, 06, 05),
            Title = "The Truman Show",
            Year = 1998
        },
        new Movie /* 209 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 111,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(2007, 06, 29),
            Title = "Ratatouille",
            Year = 2007
        },
        new Movie /* 210 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 143,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2003, 07, 09),
            Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
            Year = 2003
        },
        new Movie /* 211 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 106,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2008, 12, 12),
            Title = "Ip Man",
            Year = 2008
        },
        new Movie /* 212 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 112,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2007, 05, 23),
            Title = "The Diving Bell and the Butterfly",
            Year = 2007
        },
        new Movie /* 213 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 130,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2011, 07, 15),
            Title = "Harry Potter and the Deathly Hallows: Part 2",
            Year = 2011
        },
        new Movie /* 214 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 99,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1967, 01, 18),
            Title = "A Fistful of Dollars",
            Year = 1964
        },
        new Movie /* 215 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 125,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1951, 12, 1),
            Title = "A Streetcar Named Desire",
            Year = 1951
        },
        new Movie /* 216 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 92,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(2001, 11, 02),
            Title = "Monsters, Inc.",
            Year = 2001
        },
        new Movie /* 217 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 133,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1994, 02, 25),
            Title = "In the Name of the Father",
            Year = 1993
        },
        new Movie /* 218 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 127,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2009, 05, 08),
            Title = "Star Trek",
            Year = 2009
        },
        new Movie /* 219 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 84,
            Rating = MovieRating.G,
            ReleaseDate = new DateOnly(1991, 11, 22),
            Title = "Beauty and the Beast",
            Year = 1991
        },
        new Movie /* 220 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 136,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1968, 06, 12),
            Title = "Rosemary's Baby",
            Year = 1968
        },
        new Movie /* 221 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 104,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1950, 10, 13),
            Title = "Harvey",
            Year = 1950
        },
        new Movie /* 222 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 117,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1984, 3, 11),
            Title = "Nauticaä of the Valley of the Wind",
            Year = 1984
        },
        new Movie /* 223 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 109,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2009, 01, 30),
            Title = "The Wrestler",
            Year = 2008
        },
        new Movie /* 224 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 133,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1930, 08, 24),
            Title = "All Quiet on the Western Front",
            Year = 1930
        },
        new Movie /* 225 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 98,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1996, 02, 23),
            Title = "La Haine",
            Year = 1995
        },
        new Movie /* 226 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 133,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1988, 12, 16),
            Title = "Rain Man",
            Year = 1988
        },
        new Movie /* 227 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 66,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1925, 12, 24),
            Title = "Battleship Potemkin",
            Year = 1925
        },
        new Movie /* 228 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 138,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2010, 02, 19),
            Title = "Shutter Island",
            Year = 2010
        },
        new Movie /* 229 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 81,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1929, 6, 3),
            Title = "Nosferatu",
            Year = 1922
        },
        new Movie /* 230 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 103,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2003, 09, 19),
            Title = "Spring, Summer, Fall, Winter... and Spring",
            Year = 2003
        },
        new Movie /* 231 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 96,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1979, 04, 25),
            Title = "Manhattan",
            Year = 1979
        },
        new Movie /* 232 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 138,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2003, 10, 15),
            Title = "Mystic River",
            Year = 2003
        },
        new Movie /* 233 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 102,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1938, 2, 18),
            Title = "Bringing Up Baby",
            Year = 1938
        },
        new Movie /* 234 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 108,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1943, 1, 15),
            Title = "Shadow of a Doubt",
            Year = 1943
        },
        new Movie /* 235 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 125,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2004, 01, 09),
            Title = "Big Fish",
            Year = 2003
        },
        new Movie /* 236 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 124,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1986, 08, 02),
            Title = "Castle in the Sky",
            Year = 1986
        },
        new Movie /* 237 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 151,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1973, 12, 16),
            Title = "Papillon",
            Year = 1973
        },
        new Movie /* 238 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 76,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(1993, 10, 29),
            Title = "The Nightmare Before Christmas",
            Year = 1993
        },
        new Movie /* 239 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 119,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(1987, 06, 03),
            Title = "The Untouchables",
            Year = 1987
        },
        new Movie /* 240 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 127,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(1993, 06, 11),
            Title = "Jurassic Park",
            Year = 1993
        },
        new Movie /* 241 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 115,
            Rating = MovieRating.R,
            ReleaseDate = new DateOnly(2008, 10, 24),
            Title = "Let the Right One In",
            Year = 2008
        },
        new Movie /* 242 */
        {
            Id = idx++,
            BestPictureWinner = true,
            Duration = 109,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1967, 10, 14),
            Title = "In the Heat of the Night",
            Year = 1967
        },
        new Movie /* 243 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 170,
            Rating = MovieRating.PG13,
            ReleaseDate = new DateOnly(2009, 12, 24),
            Title = "3 Idiots",
            Year = 2009
        },
        new Movie /* 244 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 118,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1944, 9, 23),
            Title = "Arsenic and Old Lace",
            Year = 1944
        },
        new Movie /* 245 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 119,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1956, 3, 13),
            Title = "The Searchers",
            Year = 1956
        },
        new Movie /* 246 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 98,
            Rating = MovieRating.PG,
            ReleaseDate = new DateOnly(2000, 09, 29),
            Title = "In the Mood for Love",
            Year = 2000
        },
        new Movie /* 247 */
        {
            Id = idx++,
            BestPictureWinner = false,
            Duration = 141,
            Rating = MovieRating.Unrated,
            ReleaseDate = new DateOnly(1959, 4, 4),
            Title = "Rio Bravo",
            Year = 1959
        }
    ];
}
