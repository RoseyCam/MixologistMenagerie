using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// bag of stats, designed to be modifiable if we go a different direction
[System.Serializable]
public struct Attributes
{
    // wip stats, subject to change
    public int AttackUp;
    public int Sweetness;
    public int Bitter;
    public int FireDefense;

    // allows attributes to be combined with the + opertator
    public static Attributes operator + (Attributes lhs, Attributes rhs)
    {
        Attributes output = new Attributes();
        output.AttackUp = lhs.AttackUp + rhs.AttackUp;
        output.Sweetness = lhs.Sweetness + rhs.Sweetness;
        output.Bitter = lhs.Bitter + rhs.Bitter;
        output.FireDefense = lhs.FireDefense + rhs.FireDefense;
        return output;
    }


    // allows attributes to be combined with the + opertator
    public static Attributes operator - (Attributes lhs, Attributes rhs)
    {
        Attributes output = new Attributes();
        output.AttackUp = lhs.AttackUp - rhs.AttackUp;
        output.Sweetness = lhs.Sweetness - rhs.Sweetness;
        output.Bitter = lhs.Bitter - rhs.Bitter;
        output.FireDefense = lhs.FireDefense - rhs.FireDefense;
        return output;
    }

    // returns a safe string of thiss structs contents
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        if(AttackUp != 0)
        {
            output.Append("Attack Up: " + AttackUp);
        }
        if(Sweetness != 0)
        {
            output.Append("Sweetness: " + Sweetness);
        }
        if(Bitter != 0)
        {
            output.Append("Bitterness: " + Bitter);
        }
        if(FireDefense != 0)
        {
            output.Append("Fire Defense: " + FireDefense);
        }
        return output.ToString();
    }

}
