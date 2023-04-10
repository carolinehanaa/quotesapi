using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;


namespace HanaC_AllForOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AllAffirmations : Controller
    {

        public List<QuotesListModel> quotesList = new List<QuotesListModel>()
        {
            new QuotesListModel(){
                quote = "All our dreams can come true, if we have the courage to pursue them. —Walt Disney",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"I’ve missed more than 9,000 shots in my career. I’ve lost almost 300 games. 26 times I’ve been trusted to take the game winning shot and missed. I’ve failed over and over and over again in my life, and that is why I succeed.\" —Michael Jordan",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"You’ve gotta dance like there’s nobody watching, love like you’ll never be hurt, sing like there’s nobody listening, and live like it’s heaven on earth.\" —William W. Purkey",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Success is not final; failure is not fatal: It is the courage to continue that counts.\" — Winston S. Churchill",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"If people are doubting how far you can go, go so far that you can’t hear them anymore.\" —Michele Ruiz",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"I have not failed. I've just found 10,000 ways that won't work.\" -Thomas A. Edison",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = ".",
                category = "."
            },
            new QuotesListModel(){
                quote = "\"If you don't value your time, neither will others. Stop giving away your time and talents--start charging for it.\" -Kim Garst",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Be miserable. Or motivate yourself. Whatever has to be done, it's always your choice.\" – Wayne Dyer",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Don't settle for average. Bring your best to the moment. Then, whether it fails or succeeds, at least you know you gave all you had.\" -Angela Bassett",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Impossible is just an opinion.\" -Paulo Coelho",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"If something is important enough, even if the odds are stacked against you, you should still do it.\" -Elon Musk",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Work like there is someone working 24 hours a day to take it away from you.\" ―Mark Cuban",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"If you hear a voice within you say, ‘You cannot paint,’ then by all means paint, and that voice will be silenced.\" ―Vincent Van Gogh",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"The past can hurt. But the way I see it, you can either run from it, or learn from it.\" -Walt Disney",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Life is 10% what happens to you and 90% how you react to it.\" — Charles R. Swindoll",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"You don't always need a plan. Sometimes you just need to breathe, trust, let go, and see what happens.\" — Mandy Hale",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Be there for others, but never leave yourself behind.\" — Dodinsky",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"What we fear of doing most is usually what we most need to do.\" — Ralph Waldo Emerson",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"You are never too old to set another goal or to dream a new dream.\" — C.S. Lewis",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"Try to be a rainbow in someone else’s cloud.\" —Maya Angelou",
                category = "motivational"
            },
            new QuotesListModel(){
                quote = "\"You know you’re in love when you can’t fall asleep because reality is finally better than your dreams. \" -Dr. Seuss",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Maybe you don't need the whole world to love you. Maybe you just need one person.\" - Kermit the Frog",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"No matter how bad your heart is broken, the world doesn’t stop for your grief.\" -Faraaz Kazi",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Cry. Forgive. Learn. Move on. Let your tears water the seeds of your future happiness\" -Steve Maraboli",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Cry. Forgive. Learn. Move on. Let your tears water the seeds of your future happiness.\"  -Washington Irving",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Forget all the reasons why your relationship won't work. And believe the one reason why it will.\" -Heart Whisperer.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Hold no grudges and practice forgiveness. This is the key to having peace in all your relationships.\"  -Wayne Dyer.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"If your love for another person doesn't include loving yourself, then your love is incomplete.\" -Shannon L. Alder.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Ask anyone who has been in a love relationship for a while: nothing is perfect.\" -Tracy McMillan.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"A relationship is like a house. When a light bulb burns out, you do not go and buy a new house, you fix the light bulb.\" -Bernajoy Vaal.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"When in a relationship, a real man doesn't make his woman jealous of others, he makes others jealous of his woman.\" -Steve Maraboli.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Nothing is perfect. Life is messy. Relationships are complex. Outcomes are uncertain. People are irrational.\"  -Pietro Aretino.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Hold no grudges and practice forgiveness. This is the key to having peace in all your relationships.\" -Wayne Dyer.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Problems should be like speed bumps. You slow down just to get over it, but you don't let it stop you from heading to your destination.\" -Sonya Parker.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"If you can't be happy and content by yourself, then you shouldn't be in a relationship.\" -Evan Sutter.",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"We loved with a love that was more than love.\" -Edgar Allen Poe",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Love is an endless act of forgiveness. Forgiveness is me giving up the right to hurt you for hurting me.\" -Beyoncé",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"Fall in love with someone who makes you glad to be different.\" -Sue Zhao",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"There is no love without forgiveness, and there is no forgiveness without love.\" -Bryant H. McGill",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"You know it's love when all you want is that person to be happy, even if you're not part of their happiness.\" -Julia Roberts",
                category = "relationship"
            },
            new QuotesListModel(){
                quote = "\"The hardest challenge is to be yourself in a world where everyone is trying to make you be somebody else.\" - E. E. Cummings",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"If you have the ability to love, love yourself first.\" -Charles Bukowski",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"It is interesting how often we can’t see all the ways in which we are being strong.\" -Lena Dunham",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"You yourself, as much as anybody in the entire universe, deserve your love and affection.\" -Buddha",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"I now see how owning our story and loving ourselves through that process is the bravest thing that we will ever do.\" -Brené Brown",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Your self-worth is determined by you. You don’t have to depend on someone telling you who you are.\" -Beyoncé",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Once you’ve accepted your flaws, no one can use them against you.\" -George R.R. Martin",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Life isn’t about finding yourself. Life is about creating yourself.\" -George Bernard Shaw",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"If you’re not someone who has a natural and effortless love for yourself, it’s hard to let go of your desire to please other people, and that’s really not an ingredient for a happy life.\" -Anne Hathaway",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"And you? When will you begin that long journey into yourself?\" -Rumi",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"I must undertake to love myself and to respect myself as though my very life depends upon self-love and self-respect.\" -Maya Angelou",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"When you take care of yourself, you’re a better person for others. When you feel good about yourself, you treat others better.\" -Solange Knowles",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Talk to yourself like someone you love.\" -Brené Brown",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Love yourself. Be clear on how you want to be treated. Know your worth. Always.\" –Maryam Hasnaa",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"How you love yourself is how you teach others to love you.\" -Rupi Kaur",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"I am my own experiment. I am my own work of art.\" -Madonna",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Self-love has very little to do with how you feel about your outer self. It’s about accepting all of yourself.\" -Tyra Banks",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"To fall in love with yourself is the first secret to happiness.\" -Robert Morely",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Choose, everyday, to forgive yourself. You are human, flawed, and most of all worthy of love\" -Alison Malee",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"Remember, you have been criticizing yourself for years, and it hasn’t worked. Try approving of yourself and see what happens.\" -Louise L. Hay",
                category = "selfworth"
            },
            new QuotesListModel(){
                quote = "\"You say you’re ‘depressed’ – all I see is resilience. You are allowed to feel messed up and inside out. It doesn’t mean you’re defective – it just means you’re human.\" -David Mitchell, Cloud Atlas",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"You say you’re ‘depressed’ – all I see is resilience. You are allowed to feel messed up and inside out. It doesn’t mean you’re defective – it just means you’re human.\" -David Mitchell, Cloud Atlas",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Depression, suffering and anger are all part of being human.\" –Janet Fitch",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"I found that with depression, one of the most important things you could realize is that you're not alone.\" -Dwayne Johnson",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"If you know someone who's depressed, please resolve to never ask why. Depression isn't a straightforward response to a bad situation; depression just is, like the weather.\" -Stephen Fry",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Depression is like a bruise that never goes away. A bruise in your mind. You just got to be careful not to touch it where it hurts. It's always here, though.\" -Jeffrey Eugenides",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"It is very hard to explain to people who have never known serious depression or anxiety the sheer continuous intensity of it. There is no off switch.\" -Matt Haig",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Sadness is but a wall between two gardens.\" -Khalil Gibran",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"There is hope, even when your brain tells you there isn't.\" -John Green",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Sad hurts but it's a healthy feeling. It is a necessary thing to feel. Depression is very different.\" -J.K. Rowling",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"You cannot protect yourself from sadness without protecting yourself from happiness.\" -Jonathan Safran Foer",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Almost everyone is overconfident—except the people who are depressed, and they tend to be realists.\" -Joseph T. Hallinan",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"If you are depressed, you are living in the past. If you are anxious, you are living in the future. If you are at peace you are living in the present.\" -Lao Tzu",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"I believe that words are strong, that they can overwhelm what we fear when fear seems more awful than life is good.\" -Andrew Solomon",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"You’re like a grey sky. You’re beautiful, even though you don’t want to be.\" -Jasmine Warga",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"There is hope, even when your brain tells you there isn’t.\"  -John Green",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Even if you’re on the right track, you’ll get run over if you just sit there.\" -Will Rogers",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Our greatest glory is not in never falling, but in rising every time we fall.\" -Confucius",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"In three words I can sum up everything I’ve learned about life. It goes on.\" -Robert Frost",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"It’s one of the greatest gifts you can give yourself, to forgive. Forgive everybody.\" —Maya Angelou",
                category = "depression"
            },
            new QuotesListModel(){
                quote = "\"Let your mind and heart rest for a while. You will catch up, the world will not stop spinning for you, but you will catch up. Take a rest.\" – Cynthia Go",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Our anxiety does not come from thinking about the future, but from wanting to control it.\" – Kahlil Gibran",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Whatever you do, never run back to what broke you.\" – Frank Ocean",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"You can spend minutes, hours, days, weeks, or even months over-analysing a situation; trying to put the pieces together, justifying what could’ve, would’ve happened… or you could just leave the pieces on the floor and move on.\" – Tupac",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Change is hard at first, messy in the middle, and gorgeous at the end.\" – Robin Sharma",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"No need to hurry. No need to sparkle. No need to be anybody but oneself.\"  -Virginia Woolf",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Stress is an ignorant state. It believes that everything is an emergency. Nothing is that important.\" -Natalie Goldberg",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"There is only one way to happiness and that is to cease worrying about things which are beyond the power of our will.\" -Epictetus",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Anxiety does not empty tomorrow of its sorrows, but only empties today of its strength.\" -Charles Spurgeon",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"You cannot always control what goes on outside, but you can always control what goes on inside.\" -Wayne Dyer",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Anxiety is the dizziness of freedom.\" -Soren Kierkegaard",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"It’s OKAY to be scared. Being scared means you’re about to do something really, really brave.\" – Mandy Hale",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"I promise you nothing is as chaotic as it seems. Nothing is worth diminishing your health. Nothing is worth poisoning yourself into stress, anxiety, and fear.\" – Steve Maraboli",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Our anxiety does not come from thinking about the future, but from wanting to control it.\" – Kahlil Gibran",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"If you treat every situation as a life and death matter, you’ll die a lot of times.\" – Dean Smith",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Rule number one is, don’t sweat the small stuff. Rule number two is, it’s all small stuff.\" – Robert Eliot",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Breathe. Let go. And remind yourself that this very moment is the only one you know you have for sure.\" —Oprah Winfrey",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Take a deep breath, pick yourself up, dust yourself off, and start all over again.\" —Frank Sinatra",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"We breathe so that the trees thrive and the trees breathe so that we are able to live.\" —Sanchita Pandey",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"Breathe in. Breathe out. Move on.\" —Jimmy Buffet",
                category = "anxiety"
            },
            new QuotesListModel(){
                quote = "\"The world is full of magic things, patiently waiting for our senses to grow sharper.\" – W.B. Yeats",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"Just as a candle cannot burn without fire, man cannot live without a spiritual life.\" – Buddha",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"Since love grows within you, so beauty grows. For love is the beauty of the soul.\" – Augustine",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"Awakening is not changing who you are, but discarding who you are not.\" – Deepak Chopra",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"I understand once again that the greatness of God always reveals itself in the simple things.\" – Paulo Coelho",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"Science is not only compatible with spirituality; it is a profound source of spirituality.\" – Carl Sagan",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"The privilege of a lifetime is to become who you really are.\" – Carl Jung",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"The great thing to remember is that though our feelings come and go God's love for us does not.\" – C.S. Lewis",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"To speak gratitude is courteous and pleasant, but to live gratitude is to touch heaven.\" – Johannes A. Gaertner",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"Spirituality: the art of keeping your internal fire alive.\" – Maxime Lagacé",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"You have to grow from the inside out. None can teach you, none can make you spiritual. There is no other teacher but your own soul.\" – Swami Vivekananda",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"If you do a good job for others, you heal yourself at the same time, because a dose of joy is a spiritual cure. It transcends all barriers.\" – Ed Sullivan",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"You are never alone. You are eternally connected with everyone.\" – Amit Ray",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"We are not human beings having a spiritual experience. We are spiritual beings having a human experience.\" – Pierre Teilhard de Chardin",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"A quiet conscience makes one strong!\" – Anne Frank",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"The aim of life is to live, and to live means to be aware; joyously, drunkenly, serenely, divinely aware.\" – Henry Miller",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"You can't have a physical transformation until you have a spiritual transformation.\" – Cory Booker",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"The unexamined life is not worth living.\" – Socrates",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"It is not in the stars to hold our destiny but in ourselves.\" – William Shakespeare",
                category = "spiritual"
            },
            new QuotesListModel(){
                quote = "\"Enlightenment means taking full responsibility for your life.\" – William Blake",
                category = "spiritual"
            }


        };




        [HttpGet]
        [Route("GetQuote/{categorys}")]
        public List<QuotesListModel> GetQuote(string categorys)
        {
            var result = new List<QuotesListModel>();


            for (int i = 0; i < quotesList.Count; i++)
            {
                if (quotesList[i].category == categorys)
                {
                    result.Add(quotesList[i]);
                }


            }
            return result;
        }



        [HttpGet]
        [Route("GetAllQuotes")]

        public List<string?> GetAllQuotes(string? allQuotes)
        {
            

            var filteredQuotes = quotesList.Select(q => q.quote);
            
            return filteredQuotes.ToList();
        }
    }
}