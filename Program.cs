Character main = new Character();
Character partner = main.CreatePartner();

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Your character is: ");
Console.WriteLine();
Console.WriteLine(main.first_name + " " + main.last_name);
Console.WriteLine(main.gender + " | " + main.age + " years old");
Console.WriteLine(main.title + " of " + main.location);
Console.WriteLine();
Console.WriteLine("Traits: ");
Console.WriteLine(main.trait_1);
Console.WriteLine(main.trait_2);
Console.WriteLine(main.trait_3);
Console.WriteLine();
Console.WriteLine("Diplomacy: " + main.diplomacy + "/100");
Console.WriteLine("Military: " + main.military + "/100");
Console.WriteLine("Learning: " + main.learning + "/100");
Console.WriteLine("Wealth: " + main.wealth + "/100");

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Your character's spouse is: ");
Console.WriteLine();
Console.WriteLine(partner.first_name + " " + partner.last_name);
Console.WriteLine(partner.gender + " | " + partner.age + " years old");
Console.WriteLine(partner.title + " of " + partner.location);
Console.WriteLine();
Console.WriteLine("Traits: ");
Console.WriteLine(partner.trait_1);
Console.WriteLine(partner.trait_2);
Console.WriteLine(partner.trait_3);
Console.WriteLine();
Console.WriteLine("Diplomacy: " + partner.diplomacy + "/100");
Console.WriteLine("Military: " + partner.military + "/100");
Console.WriteLine("Learning: " + partner.learning + "/100");
Console.WriteLine("Wealth: " + partner.wealth + "/100");
Console.WriteLine("-------------------------------------------------");


class Character
{
    public String first_name;
    public String last_name;
    public int age;
    public String gender;
    public String title;
    public String location;
    public String trait_1 = "";
    public String trait_2 = "";
    public String trait_3 = "";
    public int military;
    public int learning;
    public int diplomacy;
    public int wealth;

    public String PickLocation(String title)
    {
        switch (title)
        {
            case "Baron":
            case "Baroness":
                return CharacterData.PickRandom(CharacterData.baron_location_list);
            case "Viscount":
            case "Viscountess":
                return CharacterData.PickRandom(CharacterData.viscount_location_list);
            case "Count":
            case "Countess":
                return CharacterData.PickRandom(CharacterData.count_location_list);
            case "Duke":
            case "Duchess":
                return CharacterData.PickRandom(CharacterData.duke_location_list);
            case "Prince":
            case "Princess":
                return CharacterData.PickRandom(CharacterData.prince_location_list);
            case "King":
            case "Queen":
                return CharacterData.PickRandom(CharacterData.king_location_list);
            case "Emperor":
            case "Empress":
                return CharacterData.PickRandom(CharacterData.emperor_location_list);
            default:
                return "";
        }
    }

    public int PickWealth(String title)
    {
        Random random = new Random();
        switch (title)
        {
            case "Baron":
            case "Baroness":
                return random.Next(0, 25);
            case "Viscount":
            case "Viscountess":
                return random.Next(10, 30);
            case "Count":
            case "Countess":
                return random.Next(15, 40);
            case "Duke":
            case "Duchess":
                return random.Next(25, 55);
            case "Prince":
            case "Princess":
                return random.Next(40, 75);
            case "King":
            case "Queen":
                return random.Next(60, 90);
            case "Emperor":
            case "Empress":
                return random.Next(80, 100);
            default:
                return 0;
        }
    }

    public void ApplyTrait(String trait)
    {
        switch (trait)
        {
            case "Ambitious":
                learning += 10;
                diplomacy += 5;
                military += 5;
                wealth += 5;
                break;
            case "Shy":
                diplomacy -= 10;
                military -= 5;
                learning += 5;
                break;
            case "Sadistic":
                diplomacy -= 5;
                military += 10;
                break;
            case "Brave":
                military += 15;
                break;
            case "Diligent":
                learning += 5;
                diplomacy += 5;
                wealth += 5;
                break;
            case "Intelligent":
                learning += 15;
                diplomacy += 5;
                military += 5;
                break;
            case "Gregarious":
                diplomacy += 10;
                learning -= 5;
                break;
            case "Temperate":
                diplomacy += 5;
                learning += 5;
                break;
            case "Stubborn":
                diplomacy -= 5;
                military -= 5;
                learning += 10;
                break;
            case "Content":
                diplomacy -= 5;
                learning += 5;
                wealth -= 5;
                break;
            case "Deceitful":
                diplomacy -= 5;
                military += 10;
                break;
            case "Greedy":
                diplomacy -= 5;
                military -= 5;
                wealth += 10;
                break;
            case "Arrogant":
                diplomacy -= 5;
                military += 5;
                break;
            case "Wrathful":
                diplomacy -= 5;
                military += 10;
                break;
            case "Compassionate":
                diplomacy += 5;
                learning += 5;
                military -= 10;
                break;
            case "Calm":
                diplomacy += 5;
                learning += 5;
                break;
            case "Forgiving":
                learning += 5;
                diplomacy += 5;
                military -= 5;
                break;
            case "Craven":
                diplomacy -= 5;
                military -= 10;
                learning += 5;
                break;
            case "Humble":
                diplomacy += 5;
                military -= 5;
                learning += 5;
                break;
            case "Just":
                diplomacy += 5;
                learning += 5;
                break;
            case "Zealous":
                diplomacy -= 5;
                military += 5;
                learning += 5;
                break;
            case "Lazy":
                diplomacy -= 5;
                military -= 5;
                learning -= 10;
                wealth -= 5;
                break;
        }
    }

    public Character()
    {
        last_name = CharacterData.PickRandom(CharacterData.last_name_list);
        Random random = new Random();
        age = random.Next(16, 100);
        gender = CharacterData.PickRandom(CharacterData.gender_list);
        if (gender == "Male")
        {
            first_name = CharacterData.PickRandom(CharacterData.male_first_name_list);
            title = CharacterData.PickRandom(CharacterData.male_title_list);
        }
        else
        {
            first_name = CharacterData.PickRandom(CharacterData.female_first_name_list);
            title = CharacterData.PickRandom(CharacterData.female_title_list);
        }

        location = PickLocation(title);
        wealth = PickWealth(title);

        military = random.Next(0, 90);
        diplomacy = random.Next(0, 90);
        learning = random.Next(0, 90);
        trait_1 = CharacterData.PickRandom(CharacterData.trait_list);
        trait_2 = CharacterData.PickRandom(CharacterData.trait_list);
        while (trait_1 == trait_2)
        {
            trait_2 = CharacterData.PickRandom(CharacterData.trait_list);
        }
        trait_3 = CharacterData.PickRandom(CharacterData.trait_list);
        while (trait_3 == trait_1 || trait_3 == trait_2)
        {
            trait_3 = CharacterData.PickRandom(CharacterData.trait_list);
        }
        ApplyTrait(trait_1);
        ApplyTrait(trait_2);
        ApplyTrait(trait_3);

        if (diplomacy > 100)
        {
            diplomacy = 100;
        }
        if (military > 100)
        {
            military = 100;
        }
        if (learning > 100)
        {
            learning = 100;
        }
        if (wealth > 100)
        {
            wealth = 100;
        }
        if (diplomacy < 0)
        {
            diplomacy = 0;
        }
        if (military < 0)
        {
            military = 0;
        }
        if (learning < 0)
        {
            learning = 0;
        }
        if (wealth < 0)
        {
            wealth = 0;
        }
    }

    public Character CreatePartner()
    {
        Character partner = new Character();
        Random random = new Random();
        partner.age = age + random.Next(-10, 11);
        if (gender == "Male")
        {
            partner.gender = "Female";
        }
        else
        {
            partner.gender = "Male";
        }
        partner.last_name = last_name;
        switch (title)
        {
            case "Baron":
                partner.title = "Baroness";
                break;
            case "Baroness":
                partner.title = "Baron";
                break;
            case "Viscount":
                partner.title = "Viscountess";
                break;
            case "Viscountess":
                partner.title = "Viscount";
                break;
            case "Count":
                partner.title = "Countess";
                break;
            case "Countess":
                partner.title = "Count";
                break;
            case "Duke":
                partner.title = "Duchess";
                break;
            case "Duchess":
                partner.title = "Duke";
                break;
            case "Prince":
                partner.title = "Princess";
                break;
            case "Princess":
                partner.title = "Prince";
                break;
            case "King":
                partner.title = "Queen";
                break;
            case "Queen":
                partner.title = "King";
                break;
            case "Emperor":
                partner.title = "Empress";
                break;
            case "Empress":
                partner.title = "Emperor";
                break;
        }
        partner.location = location;
        partner.wealth = PickWealth(partner.title);
        return partner;
    }
}

static class CharacterData
{
    public static String[] male_first_name_list = 
        [
        "Edward", "William", "Charles", "George", "Henry", "Richard", "James", "Philip", "Andrew"
        ];
    public static String[] female_first_name_list = 
        [
        "Matilda", "Anne", "Catherine", "Elizabeth", "Victoria", "Charlotte", "Mary"
        ];
    public static String[] last_name_list = 
        [
        "Windsor", "Plantagenet", "Tudor", "Hanover", "Stuart", "Capet", "Habsburg"
        ];
    public static String[] gender_list = ["Male", "Female"];
    public static String[] male_title_list = 
        [
        "Baron", "Viscount", "Count", "Duke", "Prince", "King", "Emperor"
        ];
    public static String[] female_title_list = 
        [
        "Baroness", "Viscountess", "Countess", "Duchess", "Princess", "Queen", "Empress"
        ];
    public static String[] baron_location_list =
        [
    "Yorkshire", "Kent", "Sussex", "Norfolk", "Suffolk", "Cornwall", "Devon", "Somerset", "Essex", "Cheshire"
        ];
    public static String[] viscount_location_list =
        [
    "Hereford", "Chester", "Stafford", "Worcester", "Durham", "Oxford", "Leicester", "Warwick"
        ];
    public static String[] count_location_list =
        [
    "Anjou", "Flanders", "Champagne", "Provence", "Burgundy", "Toulouse", "Blois"
        ];
    public static String[] duke_location_list =
        [
    "York", "Lancaster", "Norfolk", "Cornwall", "Somerset", "Cambridge", "Gloucester", "Buckingham"
        ];
    public static String[] prince_location_list =
        [
    "Wales", "Scotland", "Normandy", "Aquitaine", "England"
        ];
    public static String[] king_location_list =
        [
    "England", "Scotland", "Ireland", "Great Britain"
        ];
    public static String[] emperor_location_list =
        [
    "the British Empire", "the Holy Roman Empire", "North Sea Empire"
        ];
    public static String[] trait_list =
        [
    "Ambitious", "Shy", "Sadistic", "Brave", "Diligent", "Intelligent", "Gregarious", "Temperate", "Stubborn", "Content", "Decietful", "Greedy",
    "Arrogant", "Wrathful", "Compassionate", "Calm", "Forgiving", "Craven", "Humble", "Just", "Zealous", "Lazy"
        ];
    public static String PickRandom(String[] list)
    {
        Random random = new Random();
        int random_index = random.Next(0, list.Length);
        String chosen = list[random_index];
        return chosen;
    }
}
