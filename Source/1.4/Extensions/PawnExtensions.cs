namespace SaveOurShip2
{
    using RimWorld;
    using UnityEngine;
    using Verse;

    public static class PawnExtensionsz
    {
        public static float DecompressionResistance(this Pawn pawn)
        {
            float resistance = pawn.GetStatValue(ResourceBank.StatDefOf.DecompressionResistance);
            resistance += pawn.CurrentBed()?.GetStatValue(ResourceBank.StatDefOf.DecompressionResistanceOffset) ?? 0.0f;
            return Mathf.Clamp(resistance, 0.0f, 1.0f);
        }

        public static float HypoxiaResistance(this Pawn pawn)
        {
            float resistance = pawn.GetStatValue(ResourceBank.StatDefOf.HypoxiaResistance);
            resistance += pawn.CurrentBed()?.GetStatValue(ResourceBank.StatDefOf.HypoxiaResistanceOffset) ?? 0.0f;
            return Mathf.Clamp(resistance, 0.0f, 1.0f);
        }

        public static bool CanSurviveVacuum(this Pawn pawn)
        {
            return pawn.DecompressionResistance() >= 1.0f && pawn.HypoxiaResistance() >= 1.0f;
        }
    }
}

