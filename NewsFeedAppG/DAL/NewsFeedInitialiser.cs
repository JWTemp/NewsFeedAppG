using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NewsFeedAppG.Models;

namespace NewsFeedAppG.DAL
{
    public class NewsFeedInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<NewsFeedContext>
    {
        protected override void Seed(NewsFeedContext context)
        {
            //base.Seed(context);
            var newsItems = new List<NewsItem>
            {
                new NewsItem
                {
                    title = "Rally highlights steel industry 'crisis'",
                    description = "The government is to be asked for urgent help to aid Britain's ailing steel industry by workers and families attending a rally in Sheffield.",
                    link = "http://www.bbc.co.uk/news/uk-england-34889040",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 04:25:38 GMT")
                },
                new NewsItem
                {
                    title = "IRA pub bombings anniversary service",
                    description = "Relatives of victims of the IRA Birmingham pub bombings will attend a memorial service later to mark the 41st anniversary of the attacks.",
                    link = "http://www.bbc.co.uk/news/uk-england-birmingham-34889613",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 10:48:50 GMT")
                },
                new NewsItem
                {
                    title = "Greek island kitchen to feed refugees",
                    description = "A group of anti-food waste campaigners are travelling to a Greek Island to help cook hot meals for refugees heading for Europe.",
                    link = "http://www.bbc.co.uk/news/uk-england-bristol-34889976",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 13:35:21 GMT")
                },
                new NewsItem
                {
                    title = "Reward over £1.1m rail arson attack",
                    description = "A £30,000 reward is offered after an arson attack caused widespread disruption to train services that cost Network Rail more than £1m.",
                    link = "http://www.bbc.co.uk/news/uk-england-34890272#sa-ns_mchannel=rss&amp;ns_source=PublicRSS20-sa",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 12:56:13 GMT")
                },
                new NewsItem
                {
                    title = "Teenager in court over school stabbings",
                    description = "A 15-year-old boy is remanded in youth detention after being charged over the stabbing of two pupils at a school in Dulwich.",
                    link = "http://www.bbc.co.uk/news/uk-england-london-34890234",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 12:50:42 GMT")
                },
                new NewsItem
                {
                    title = "Grandson murder accused 'confessed'",
                    description = "A man accused of murdering his nine-year-old grandson confessed to drowning the boy to a GP at a police station, a court hears.",
                    link = "http://www.bbc.co.uk/news/uk-england-lincolnshire-34889789",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 12:00:17 GMT")
                },
                new NewsItem
                {
                    title = "Further arrests over man's flat death",
                    description = "Two more people are arrested on suspicion of murdering a 24-year-old man in the West Midlands",
                    link = "http://www.bbc.co.uk/news/uk-england-birmingham-34889607",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 10:12:43 GMT")
                },
                new NewsItem
                {
                    title = "Man charged after baby boy injured",
                    description = "A man is charged with causing grievous bodily harm following an assault on a six-month-old baby.",
                    link = "http://www.bbc.co.uk/news/uk-england-somerset-34889972",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 11:58:31 GMT")
                },
                new NewsItem
                {
                    title = "Snow brings winter to the South East",
                    description = ">Winter arrives in the South East as the Met Office warns of difficult driving conditions and issues a yellow warning of wind and snow.",
                    link = "http://www.bbc.co.uk/news/uk-england-kent-34889759",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 12:37:26 GMT")
                },
                new NewsItem
                {
                    title = "Britain's Haskins takes world title",
                    description = "Bristol's Lee Haskins takes the IBF world bantamweight title without throwing a punch as holder Randy Caballero is deemed too heavy to fight.",
                    link = "http://www.bbc.co.uk/sport/0/boxing/34889315",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 09:32:07 GMT")
                },
                new NewsItem
                {
                    title = "Jones will meet captain Robshaw",
                    description = "New England head coach Eddie Jones intends to meet Chris Robshaw after criticising the captain during the World Cup.",
                    link = "http://www.bbc.co.uk/sport/0/rugby-union/34886211",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Fri, 20 Nov 2015 22:01:11 GMT")
                },
                new NewsItem
                {
                    title = "I expect more from Depay - Van Gaal",
                    description = "Manchester United manager Louis van Gaal says he wants more from 'inconsistent' winger Memphis Depay.",
                    link = "http://www.bbc.co.uk/sport/0/football/34884773",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Fri, 20 Nov 2015 22:32:25 GMT")
                },
                new NewsItem
                {
                    title = "Bath can win Champions Cup - Watson",
                    description = "Bath back Anthony Watson believes his side can win the European Champions Cup this season.",
                    link = "http://www.bbc.co.uk/sport/0/rugby-union/34879688",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 11:13:57 GMT")
                },
                new NewsItem
                {
                    title = "Tax credits a 'judgement call'",
                    description = "The Chancellor tells the Treasury Select Committee he is 'comfortable' with his decision on tax credits",
                    link = "http://www.bbc.co.uk/news/uk-politics-parliaments-34606008",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Fri, 23 Oct 2015 15:36:15 GMT")
                },
                new NewsItem
                {
                    title = "Transphobic crime up 25% in London",
                    description = "Figures recorded by the Met Police show a 25% increase in hate crimes against transgender people this year.",
                    link = "http://www.bbc.co.uk/news/world-34890232",
                    image = "",
                    author = "",
                    caption = "",
                    published_date = DateTime.Parse("Sat, 21 Nov 2015 12:38:42 GMT")
                }
            };

            newsItems.ForEach(n => context.NewsItems.Add(n));
            //and just in case there's a problem
            context.SaveChanges();

        }
    }
}