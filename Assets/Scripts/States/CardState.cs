using Assets.Scripts.Models;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.States
{
    public class CardState : MonoBehaviour
    {
        public CardModel BaseCard { get; set; }
        public List<TraitModel> Traits { get; set; }
        public int HP { get; set; }
        public CardState()
        {

        }
        public CardState(int hp, TraitModel trait)
        {
            HP = hp;
            Traits.Add(trait);
        }
    }
}
