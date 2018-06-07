using Assets.Scripts.Models;
using Assets.Scripts.States;

namespace Assets.Scripts.Services
{
    public static class CraftService
    {
        public static CardState Craft(TraitModel trait, CardModel card)
        {
            return new CardState(card.maxHp, trait);
        }
    }
}
