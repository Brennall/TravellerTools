﻿using Grauenwolf.TravellerTools.Characters.Careers;

namespace Grauenwolf.TravellerTools.Characters
{
    class Wanderer : Drifter
    {
        public Wanderer() : base("Wanderer") { }

        protected override string AdvancementAttribute
        {
            get { return "Str"; }
        }

        protected override int AdvancementTarget
        {
            get { return 7; }
        }

        protected override string SurvivalAttribute
        {
            get { return "End"; }
        }

        protected override int SurvivalTarget
        {
            get { return 7; }
        }

        protected override void AssignmentSkills(Character character, Dice dice, int roll, bool level0)
        {
            switch (roll)
            {
                case 1:
                    return;
                case 2:
                    return;
                case 3:
                    return;
                case 4:
                    return;
                case 5:
                    return;
                case 6:
                    return;
            }
        }

        internal override void UpdateTitle(Character character, CareerHistory careerHistory)
        {

        }
    }
}

