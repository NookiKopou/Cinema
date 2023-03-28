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
                        carrier = "Диск",
                        price = 300,
                        trailer = "https://www.youtube.com/watch?v=R44_5Of3lM0",
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
                        carrier = "Кассета",
                        price = 200,
                        trailer = "https://www.youtube.com/watch?v=Lv02OVOZrBY",
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
                        carrier = "Диск",
                        price = 300,
                        trailer = "https://www.youtube.com/watch?v=jt1ForrxS38",
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
                        carrier = "USB",
                        price = 300,
                        trailer = "https://www.youtube.com/watch?v=Iea_m20ZV1g",
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
                        carrier = "USB",
                        price = 300,
                        trailer = "https://www.youtube.com/watch?v=96Zqy63mH9M",
                        duration = 97,
                        place = "Зал 2",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.Last()
                    },
                    new Movie
                    {
                        name = "Другая",
                        desc = "История пропавшей без вести и вскоре найденной девочки." +
                        " Однако ее брат начинает подозревать, что вместо ребенка в мир" +
                        " пришли некие злые силы.",
                        grade = 5.3,
                        img = "/img/7.jpg",
                        carrier = "Диск",
                        price = 150,
                        trailer = "https://www.youtube.com/watch?v=wVyjQa5KBaI",
                        duration = 83,
                        place = "Зал 3",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.First()
                    },
                    new Movie
                    {
                        name = "Астрал",
                        desc = "Джош и Рене переезжают с детьми в новый дом, но не успевают" +
                        " толком распаковать вещи, как начинаются странные события. Необъяснимо" +
                        " перемещаются предметы, в детской звучат странные звуки… Но настоящий" +
                        " кошмар начинается для родителей, когда их десятилетний сын Далтон " +
                        "впадает в кому. Все усилия врачей в больнице помочь мальчику безуспешны.",
                        grade = 6.8,
                        img = "/img/8.jpg",
                        carrier = "Диск",
                        price = 400,
                        trailer = "https://www.youtube.com/watch?v=wp5dEaaU-JE",
                        duration = 103,
                        place = "Зал 3",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.First()
                    },
                    new Movie
                    {
                        name = "Тайный Санта",
                        desc = "Юрист Светлана Соколова работает в компании Максима с самого" +
                        " основания и столько же времени они терпеть друг друга не могут. Максим" +
                        " давно бы избавился от Светланы, но понимает, что найти ей замену не " +
                        "так–то просто. Светлана в этот Новый год собирается, наконец, устроить " +
                        "свою личную жизнь. В коллективе решено провести вручение подарков от " +
                        "``Тайного Санты``, и Светлана запланировала поездку на базу отдыха для " +
                        "себя и Стаса – сотрудника, который ей нравится, но все никак не сделает" +
                        " первый шаг. Однако все идет не по плану и приглашение достается… " +
                        "Максиму. Светлана и хотела бы сбежать, но Максим намерен как следует " +
                        "отдохнуть, а она, в свою очередь, принимает решение испортить ему праздник.",
                        grade = 6.4,
                        img = "/img/9.jpg",
                        carrier = "USB",
                        price = 300,
                        trailer = "https://www.youtube.com/watch?v=KtV8SU6m9LA",
                        duration = 80,
                        place = "Зал 1",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.ElementAt(1)
                    },
                    new Movie
                    {
                        name = "Один дома",
                        desc = "Мальчик-озорник задает жару грабителям. Лучшая комедия" +
                        " для создания праздничного настроения у всей семьи",
                        grade = 8.3,
                        img = "/img/10.jpg",
                        carrier = "Кассета",
                        price = 250,
                        trailer = "https://www.youtube.com/watch?v=bBU_64CTNsw",
                        duration = 103,
                        place = "Зал 1",
                        isPopular = true,
                        Genre = _genreMovies.AllGenres.ElementAt(1)
                    },
                    new Movie
                    {
                        name = "Время",
                        desc = "Отправившись в отпуск на тропический остров, семья с двумя детьми" +
                        " решает последовать совету менеджера отеля и посетить прекрасный " +
                        "уединенный пляж. Кроме них на пляже оказываются и другие постояльцы: " +
                        "семейство с маленькой дочкой, пара среднего возраста и популярный рэпер." +
                        " Но вскоре расслабленный отдых сменяется паникой, когда компания " +
                        "обнаруживает труп и замечает, что дети вдруг начали очень быстро взрослеть.",
                        grade = 6.4,
                        img = "/img/11.jpg",
                        carrier = "Диск",
                        price = 200,
                        trailer = "https://www.youtube.com/watch?v=qtU3TvDyQaE",
                        duration = 108,
                        place = "Зал 2",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.ElementAt(2)
                    },
                    new Movie
                    {
                        name = "Никто",
                        desc = "Задетый за живое обыватель превращается в крутого " +
                        "защитника семьи. Голливудский дебют Ильи Найшуллера",
                        grade = 7.4,
                        img = "/img/12.jpg",
                        carrier = "USB",
                        price = 400,
                        trailer = "https://www.youtube.com/watch?v=ZPUM1L8iwtc",
                        duration = 92,
                        place = "Зал 3",
                        isPopular = true,
                        Genre = _genreMovies.AllGenres.ElementAt(2)
                    },
                    new Movie
                    {
                        name = "Ассасин: Битва миров",
                        desc = "В неком фэнтезийном мире правит жестокий Бог, которому нужны" +
                        " лишь смерть и разрушения. Потеряв сестру, но обретя волшебный доспех," +
                        " молодой воин Кунвэнь отправляется в путешествие, чтобы разыскать и " +
                        "убить Бога. В это время в нашем мире мужчина Гуань Нин уже шесть лет" +
                        " находится на грани отчаяния, разыскивая пропавшую дочку. Он выходит " +
                        "на торговцев детьми, но полиция ошибочно принимает его за преступника " +
                        "и арестовывает. Сбежать Нину помогает ассистентка влиятельного " +
                        "бизнесмена и предлагает ему сделку. Один популярный писатель в данный" +
                        " момент пишет роман в жанре фэнтези, который каким-то образом вредит " +
                        "здоровью её босса, а Нин в обмен на информацию о местонахождении " +
                        "дочери должен этого писателя убить.",
                        grade = 6.1,
                        img = "/img/13.jpg",
                        carrier = "Диск",
                        price = 250,
                        trailer = "https://www.youtube.com/watch?v=4fzIm7y27wY",
                        duration = 130,
                        place = "Зал 2",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.ElementAt(3)
                    },
                    new Movie
                    {
                        name = "Щелкунчик и четыре королевства",
                        desc = "Юная принцесса спасает мир Четырех королевств от Матушки Имбирь." +
                        " Фэнтези в лучших традициях диснеевских сказок",
                        grade = 6.0,
                        img = "/img/14.jpg",
                        carrier = "USB",
                        price = 200,
                        trailer = "https://www.youtube.com/watch?v=Sk-HW11epLo",
                        duration = 99,
                        place = "Зал 2",
                        isPopular = false,
                        Genre = _genreMovies.AllGenres.ElementAt(3)
                    },
                    new Movie
                    {
                        name = "Крестный отец",
                        desc = "В семье крупного нью-йоркского мафиози наметился кризис. " +
                        "Революция в гангстерском кино и начало большого эпоса",
                        grade = 8.7,
                        img = "/img/15.jpg",
                        carrier = "Кассета",
                        price = 50,
                        trailer = "https://www.youtube.com/watch?v=E3b9jVCUh7Q",
                        duration = 175,
                        place = "Зал 1",
                        isPopular = true,
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
                        carrier = "Кассета",
                        price = 400,
                        trailer = "https://www.youtube.com/watch?v=Vjq5i-yq96U",
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
