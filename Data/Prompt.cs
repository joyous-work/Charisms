namespace Charisms_2.Data
{
    public class Prompt
    {
        public int PromptId { get; set; }     //want control over the statement ids (labels)
        public string Statement { get; set; } = string.Empty;

        public Prompt(int promptId, string statement)
        {
            PromptId = promptId;
            Statement = statement;
        }
    }

    public class CharismsContext 
    {
        public static Random rng = new Random();

        public static readonly string[] Gifts = { "Writing", "Administration", "Craftsmanship",
            "Digital Media", "Discernment", "Encouragement", "Evangelism", "Faith", "Giving",
            "Healing", "Helping", "Hospitality", "Intercession", "Knowledge", "Leadership",
            "Mercy", "Global and Cultural Awareness", "Musicianship", "Shepherding", "Peacemaking",
            "Prophecy", "Service", "Teaching", "Voluntary Poverty", "Wisdom"};

        public static readonly Prompt[] Prompts = {
            new (1, "I often see the bigger picture and enjoy bringing people and project pieces together."),
            new (2, "Creating something useful or beautiful is enjoyable for me and it excites me to share my creation with others."),
            new (3, "I am very comfortable with digital projects and can easily see these endeavors through to completion."),
            new (4, "Recognizing the direction of the Holy Spirit in times of choice or conflict comes pretty easily to me. I can easily identify what is of goodness and truth and what is not."),
            new (5, "I never tire of responding to those who are discouraged, offering a listening ear and hope for the future. These opportunities are incredibly nurturing and energizing for me."),
            new (6, "I am very comfortable sharing the good news of Christ in my life with others, and this comes naturally to me."),
            new (7, "I remain steadfast in confidence that God will provide at all times regardless of overwhelming obstacles or negativity from others."),
            new (8, "I often seek out opportunities to somehow give to others because it fulfills a deeper longing in my heart. Giving is where I encounter the animating presence of Christ in my day-to-day activities."),
            new (9, "I have witnessed God’s miraculous work in my life, and am confident that my prayers for healing have made a difference."),
            new (10, "Others have told me that my help doing small, practical things made a big difference."),
            new (11, "I enjoy creating an environment of welcome and making others feel comfortable."),
            new (12, "I spend a lot of time in my prayer asking for intercession for those in need, and this fulfills me."),
            new (13, "I enjoy learning about my faith and frequently encounter God’s presence in my life through what I study."),
            new (14, "Others often look to me to create a vision for the future."),
            new (15, "The compassion I feel for others’ suffering moves me to take action to help them; when I see another person in pain, I want to accompany them in their struggle."),
            new (16, "I work hard to maintain relationships with others from different cultural and ethnic backgrounds, and they inspire my own encounter with Christ."),
            new (17, "Others say that my musical abilities enhance their experience of prayer and worship."),
            new (18, "I enjoy connecting people to one another and helping them to advance together in their spiritual journey."),
            new (19, "Others often seek me out to mediate with issues that arise."),
            new (20, "I have a strong awareness of God’s presence in my life, and this animates me to speak the truth courageously."),
            new (21, "I see ways to make things easier or better for other people or for my parish/community/workplace that others may not notice, and act without being asked."),
            new (22, "Seeing others grasp a concept gives me satisfaction."),
            new (23, "I am drawn to the simplicity in the lives of the saints and wish to model my life after theirs."),
            new (24, "Others look to me to be a “measured voice” during times of chaos."),
            new (25, "Others have told me that I am a very gifted writer and can express thoughts or concepts using words extremely well."),
            new (26, "It is easy for me to plan and follow through on projects. Others recognize my passion for this and call on me to oversee administrative tasks."),
            new (27, "Others have commented that my crafts or art is meaningful to them."),
            new (28, "I can easily navigate technology and virtual platforms, and creatively imagine ways to utilize these for enrichment."),
            new (29, "When faced with a choice, I am most comfortable stepping back and taking time in prayer to listen to the Holy Spirit."),
            new (30, "It is not uncommon for people (including complete strangers) to trust in me by sharing what is troubling their heart, and they depart comforted by my presence and words."),
            new (31, "I consider myself a storyteller of the faith. I hope to animate others by the Good News I’ve personally encountered."),
            new (32, "Trusting the Holy Spirit’s promptings, I have taken bold action in kingdom building without concrete evidence of success or what others may have considered risky or impractical."),
            new (33, "Others have expressed that I have a very generous heart and this characterizes who I am as a person. They often reach out to me to give of my time, talents or treasures."),
            new (34, "Others often ask me to pray for those who are suffering, believing God will use my prayer to bring about a remarkable healing in someone’s life."),
            new (35, "I find great fulfillment (often working behind the scenes) in supporting and enabling others to successfully accomplish what God is calling them to do."),
            new (36, "I vividly encounter Christ and the movement of the Holy Spirit in my life when I welcome others in an environment of welcome and hospitality."),
            new (37, "Others have expressed feeling peaceful after they ask me to pray for them."),
            new (38, "Others have told me that insights I gathered from my own study have helped them grow in their own faith."),
            new (39, "I am able to see the gifts that others have and put people into situations where they can best use their gifts wisely."),
            new (40, "When I am hurt by the actions of another, I do my best to understand and to forgive."),
            new (41, "I easily recognize my interconnectedness with my other brothers and sisters in faith, and work to build bridges where I can to enhance the community, especially in the peripheries of my life."),
            new (42, "I find great fulfillment in my prayer life by either singing or playing an instrument."),
            new (43, "When guiding others on their journey of faith, I prefer to have a personal relationship with each of them rather than only being acquainted with them on a superficial level."),
            new (44, "I am not reactionary with opinions or views that differ from my own; I make it a point to listen to all sides before weighing in on an opinion."),
            new (45, "I have shared messages with others that I feel God revealed to me."),
            new (46, "I find joy simply in helping; I don’t look for recognition or reward."),
            new (47, "I am able to explain things in different ways to help others understand, and this fulfills me."),
            new (48, "My faith life and spirituality are directly connected to my desire to live simply and serve the poor."),
            new (49, "In times of uncertainty, I have helped others discern good decisions that reflected God’s will in their lives."),
            new (50, "I find writing, as a form of prayer, to be very powerful for me and a creative way to express my faith."),
            new (51, "Others seek my guidance when there is confusion or uncertainty in the planning or implementation of a project."),
            new (52, "I believe using my hands to create something is a form of prayer and a way to glorify God in my life and in the Church."),
            new (53, "Others have recognized my adept skills with social media, virtual brand creation, and comfort within technological arenas and have asked me to assist with their efforts."),
            new (54, "Others recognize my quick inspiration in times that clarity of truth is needed."),
            new (55, "Others have said my presence and/or words were comforting and encouraging in times of struggle and strife, or that they felt God was working through me as an encouraging presence."),
            new (56, "Others are captivated by my joy and are curiously drawn into a deeper encounter with Christ because of my witness."),
            new (57, "Others recognize in me an unshakable trust in God, so that in times of crisis, it serves as a source of strength for them."),
            new (58, "I feel most fulfilled in my own faith walk when I can give somehow to someone in need, and this is a form of prayer for me."),
            new (59, "Others have been restored somehow physically, mentally, emotionally, or spiritually because of my care."),
            new (60, "I enjoy serving Jesus in the background in ways that can help those in the spotlight make a difference in the lives of others."),
            new (61, "Others have said they feel comfortable being themselves around me and describe me as personable and easy-going."),
            new (62, "Praying for others is an important part of my faith and others often ask me to pray for them."),
            new (63, "I am drawn to the wisdom and experiences of the saints who have emphasized excellence in study as a form of contemplation and spiritual growth."),
            new (64, "I feel empowered when I am able to see the success of others in projects I envision."),
            new (65, "Others have told me how much my presence helped them reconnect, heal, and forgive in times of struggle."),
            new (66, "Others sense my comfort in diverse situations and look to me as a bridge-builder."),
            new (67, "God blessed me with talents playing a musical instrument or by my voice, and I enjoy it very much."),
            new (68, "People tell me that I am a role model in faith and they are challenged to be better because of my example."),
            new (69, "Other say I exhibit great patience when dealing with difficult situations."),
            new (70, "Others say I speak with conviction and authority when I am advocating for someone or something; in the face of injustice, I am quick to speak up on behalf of truth and be a voice for the voiceless."),
            new (71, "Others have reached out to me, confident I am always willing to help, and asked me to serve."),
            new (72, "Others have thanked me for helping them understand information and concepts more clearly."),
            new (73, "Others have said my simple lifestyle/example challenges them to also live more simply for the benefit of those less fortunate."),
            new (74, "I appreciate complex problems and often work to come up with appropriate solutions."),
            new (75, "Others have shared that they have been influenced and nurtured by something I wrote.")
        };
    }
}