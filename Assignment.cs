public class Assignment
{
    public Card RedcliffMessenger()
    {
        Card setCard = new Card();

        setCard.Name = " Messenger";
        setCard.Team = "Redcliff";
        setCard.Power = 100;
        setCard.AssistPower = 150;
        setCard.Health = 300;
        setCard.Cost = 1;
        setCard.OnCast = true;

        return setCard;
    }

    public Card RedcliffArcher()
    {
        Card setCard = new Card();

        setCard.Name = " Archer";
        setCard.Team = "Redcliff";
        setCard.Power = 50;
        setCard.AssistPower = 150;
        setCard.Health = 500;
        setCard.Cost = 2;
        setCard.OnCast = true;
        setCard.OnAllyCast = true;

        return setCard;
    }

    public Card RedcliffMauler()
    {
        Card setCard = new Card();

        setCard.Name = " Mauler";
        setCard.Team = "Redcliff";
        setCard.Power = 200;
        setCard.AssistPower = 100;
        setCard.Health = 400;
        setCard.AssistHealth = 100;
        setCard.Cost = 3;
        setCard.OnCast = true;

        return setCard;
    }

    public Card RedcliffAdept()
    {
        Card setCard = new Card();

        setCard.Name = " Adept";
        setCard.Team = "Redcliff";
        setCard.Power = 350;
        setCard.Health = 500;
        setCard.Cost = 3;

        return setCard;
    }

    public Card RedcliffEnforcer()
    {
        Card setCard = new Card();

        setCard.Name = " Enforcer";
        setCard.Team = "Redcliff";
        setCard.Power = 500;
        setCard.AssistPower = 400;
        setCard.Health = 500;
        setCard.AssistHealth = 400;
        setCard.Cost = 5;
        setCard.OnDeath = true;
        setCard.DrawCondition = true;

        return setCard;
    }

    public Card RedcliffEliteCommander()
    {
        Card setCard = new Card();

        setCard.Name = " Elite Commander";
        setCard.Team = "Redcliff";
        setCard.Power = 500;
        setCard.AssistPower = 300;
        setCard.Health = 500;
        setCard.Cost = 5;
        setCard.EffectCondition = 1500;
        setCard.OnCast = true;
        setCard.DrawCondition = true;

        return setCard;
    }

    public Card RedcliffKing()
    {
        Card setCard = new Card();

        setCard.Name = " King Richard";
        setCard.Team = "Redcliff";
        setCard.Rank = 5;
        setCard.Power = 300;
        setCard.Health = 1200;
        setCard.Cost = 7;
        setCard.DrawCondition = true;
        setCard.OnAttack = true;

        return setCard;
    }

    public Action RedcliffDecimate()
    {
        Action setAction = new Action();

        setAction.Name = ": Decimate!";
        setAction.Team = "Redcliff";
        setAction.AssistPower = 800;
        setAction.AssistHealth = 800;
        setAction.Cost = 4;
        setAction.BoardRequirement = 1;

        SetAction.EffectDesc = ""

        return setAction;
    }

    public Action RedcliffRise()
    {
        Action setAction = new Action();

        setAction.Name = ": Rise!";
        setAction.Team = "Redcliff";
        setAction.AssistPower = 600;
        setAction.AssistHealth = 800;
        setAction.Cost = 4;
        setAction.BoardRequirement = 1;
        // If 0 on board, draw enforcer
        SetAction.EffectDesc = "All allied Redcliff fighters gain 600 Power. If none are on the board, summon a Redcliff Enforcer"

        return setAction;
    }

}
