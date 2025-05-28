namespace PruebaTelus.Models
{
    public class QuoteModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }

        public List<QuoteModel> GetList()
        {
            List<QuoteModel> Quotes = new List<QuoteModel>()
{
    new QuoteModel {
        Text = "Genius is one percent inspiration and ninety-nine percent perspiration.",
        Author= "Thomas Edison"
    },
    new QuoteModel {
        Text = "You can observe a lot just by watching.",
        Author= "Yogi Berra"
    },
    new QuoteModel {
        Text = "A house divided against itself cannot stand.",
        Author= "Abraham Lincoln"
    },
    new QuoteModel {
        Text = "Difficulties increase the nearer we get to the goal.",
        Author= "Johann Wolfgang von Goethe"
    },
    new QuoteModel {
        Text = "Fate is in your hands and no one elses",
        Author= "Byron Pulsifer"
    },
    new QuoteModel {
        Text = "Be the chief but never the lord.",
        Author= "Lao Tzu"
    },
    new QuoteModel {
        Text = "Nothing happens unless first we dream.",
        Author= "Carl Sandburg"
    },
    new QuoteModel {
        Text = "Well begun is half done.",
        Author= "Aristotle"
    },
    new QuoteModel {
        Text = "Life is a learning experience, only if you learn.",
        Author= "Yogi Berra"
    },
    new QuoteModel {
        Text = "Self-complacency is fatal to progress.",
        Author= "Margaret Sangster"
    },
    new QuoteModel {
        Text = "Peace comes from within. Do not seek it without.",
        Author= "Buddha"
    },
    new QuoteModel {
        Text = "What you give is what you get.",
        Author= "Byron Pulsifer"
    },
    new QuoteModel {
        Text = "We can only learn to love by loving.",
        Author= "Iris Murdoch"
    },
    new QuoteModel {
        Text = "Life is change. Growth is optional. Choose wisely.",
        Author= "Karen Clark"
    },
    new QuoteModel {
        Text = "You'll see it when you believe it.",
        Author= "Wayne Dyer"
    },
    new QuoteModel {
        Text = "Today is the tomorrow we worried about yesterday.",
        Author= null
    },
    new QuoteModel {
        Text = "It's easier to see the mistakes on someone else's paper.",
        Author= null
    },
    new QuoteModel {
        Text = "Every man dies. Not every man really lives.",
        Author= null
    },
    new QuoteModel {
        Text = "To lead people walk behind them.",
        Author= "Lao Tzu"
    }
};

            return Quotes;

        }
    }
}
