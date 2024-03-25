class Scripture
{
    private Reference thisone = new Reference();
    private List<string> verses = new List<string>();

    public string GiveScripture(int i)
    {
        switch (i)
        {
            case 1:
                return (@"And it came to pass that I, Nephi, said
                unto my father: I will go and do the things which the Lord hath commanded,
                for I know that the Lord giveth no commandments unto the children of men, save
                he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

            case 2:
                return (@"Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost,
                which shall cone upon you and which shall dwell in your heart.\n\n
                Now, behold, this is the spirit of revelation; behold,
                this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.");

            default:
                return ("Invalid choice, please try again");
        }
    }

}