using Cinema.Data.Interfaces;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Mocks
{
    public class MockMovies : IAllMovies
    {
        private readonly IMoviesGenre _genreMovies = new MockGenre();

        public IEnumerable<Movie> Movies
        {
            get
            {
                return new List<Movie> {
                    new Movie
                    {
                        name = "Ужасающий 2",
                        desc = "В этот Хэллоуин в городке округа Майлз снова пробуждается " +
                        "древнее зло: клоун Арт возвращается после воскрешения из мертвых. " +
                        "Чтобы остановить его, девушке с братом предстоит раскрыть секрет Арта" +
                        " и понять из какого мира он пришел.",
                        grade = 6.9,
                        img = "/img/1.jpg",
                        price = 300,
                        duration = 140,
                        place = "Зал 1",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.First()
                    },
                    new Movie
                    {
                        name = "Грозный папа",
                        desc = "Поссорившись с сыном, царь Иван Грозный случайно ранит его – как" +
                        " на знаменитой картине Репина. Жизнь царевича на волоске. Чтобы все " +
                        "исправить, Грозный хочет отправиться в прошлое с помощью волшебного " +
                        "гримуара. Однако что-то пошло не так, и Грозный попадает в наше время," +
                        " где знакомится с семьей Осиповых...",
                        grade = 6.0,
                        img = "/img/2.jpg",
                        price = 200,
                        duration = 90,
                        place = "Зал 1",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.ElementAt(1)
                    },
                    new Movie
                    {
                        name = "Шрамы Парижа",
                        desc = "В ноябре 2015 года Париж пережил самые страшные теракты в своей " +
                        "истории. Жертвами тщательно спланированных актов насилия стали почти 400" +
                        " человек. Но на этом преступники не собираются останавливаться. Чтобы" +
                        " предотвратить будущие угрозы, двум агентам придется провести одно из " +
                        "самых крупных расследований в истории Старого Света и помешать " +
                        "преступникам нанести новый удар.",
                        grade = 6.1,
                        img = "/img/3.jpg",
                        price = 300,
                        duration = 100,
                        place = "Зал 2",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.ElementAt(2)
                    },
                    new Movie
                    {
                        name = "3 тысячи лет желаний",
                        desc = "Отправившись в Стамбул, одинокая женщина случайно находит джинна," +
                        " который предлагает исполнить три её желания в обмен на свою свободу.",
                        grade = 6.9,
                        img = "/img/4.jpg",
                        price = 300,
                        duration = 108,
                        place = "Зал 2",
                        isPopular = true,
                        Genre = _genreMovies.AllGenres.ElementAt(3)
                    },
                    new Movie
                    {
                        name = "Дополнительный урок",
                        desc = "Во время очередного дежурства патрульная Вера Седова в одиночку" +
                        " предотвращает трагедию в колледже, но при этом погибает студент. Она " +
                        "утверждает, что у парня был обрез, однако никакого оружия не обнаружено." +
                        " Полицейскую проклинают родители и общественность...",
                        grade = 6.8,
                        img = "/img/5.jpg",
                        price = 300,
                        duration = 97,
                        place = "Зал 2",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.Last()
                    },
                    new Movie
                    {
                        name = "Сердце Пармы",
                        desc = "Князь Михан был рожден в языческих таежных землях – там, где шаманы" +
                        " приносили кровавые жертвы, чтобы отогнать темных духов и сохранить " +
                        "равновесие. Здесь он встретил ту, в которой – вся красота мира и сила " +
                        "ведьмы-ламии. Ту, быть с которой ему запрещают законы. Эта любовь навсегда" +
                        " изменит судьбу Михана и его родной Пармы.",
                        grade = 7.1,
                        img = "/img/6.jpg",
                        price = 400,
                        duration = 159,
                        place = "Зал 1",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.First()
                    }
                };
            }
        }

        public IEnumerable<Movie> getPopMovies { get; set; }

        public Movie getObjectMovie(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
