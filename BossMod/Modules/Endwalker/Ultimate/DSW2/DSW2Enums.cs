﻿namespace BossMod.Endwalker.Ultimate.DSW2
{
    public enum OID : uint
    {
        Boss = 0x313C, // king thordan - p2
        SerZephirin = 0x3130, // x1 - ??
        SerAdelphel = 0x3139, // x1 - p1, p2
        SerGrinnaux = 0x313A, // x1 - p1, p2
        SerCharibert = 0x313B, // x1 - ??
        SerJanlenoux = 0x3158, // x1 - p2
        SerVellguine = 0x3159, // x1 - p2
        SerPaulecrain = 0x315A, // x1 - p2
        SerIgnasse = 0x315B, // x1 - p2
        SerHermenost = 0x315C, // x1 - p2
        SerGuerrique = 0x315D, // x1 - p2
        SerHaumeric = 0x315E, // x1 - p2
        SerNoudenet = 0x315F, // x1 - p2
        //_Gen_Actor_3316 = 0x3316, // x1
        Helper = 0x233C, // x24
        Brightsphere = 0x330E, // spawn during fight by Shining Blade
        HolyComet = 0x312F, // spawn during fight by Holy Comet
    };

    public enum AID : uint
    {
        AutoAttack = 25531, // Boss->mt, no cast, range 10 ?-degree cone
        Teleport = 25540, // Boss->location, no cast
        Reappear = 25532, // Boss->self, no cast

        AscalonsMercyConcealed = 25544, // Boss->self, 3.0s cast, visual
        AscalonsMercyConcealedAOE = 25545, // Helper->self, 1.5s cast, range 50 30-degree (?) cone
        AscalonsMight = 25541, // Boss->self, no cast, range 50 60-degree (?) cone tankbuster

        KnightsOfTheRound = 25581, // Boss->self, no cast, visual
        StrengthOfTheWard = 25555, // Boss->self, 4.0s cast, visual
        LightningStorm = 25548, // Boss->self, 5.7s cast, visual
        LightningStormAOE = 25549, // Helper->player, no cast, range 5 aoe
        SpiralThrust = 25556, // SerIgnasse/SerVellguine/SerPaulecrain->self, 6.0s cast, range 52 width 16 rect aoe
        HeavyImpact = 25557, // SerGuerrique->self, 4.3s cast, visual
        HeavyImpactHit1 = 25558, // Helper->self, 6.0s cast, range 6 aoe
        HeavyImpactHit2 = 25559, // Helper->self, no cast, range 6-12 donut
        HeavyImpactHit3 = 25560, // Helper->self, no cast, range 12-18 donut
        HeavyImpactHit4 = 25561, // Helper->self, no cast, range 18-24 donut
        HeavyImpactHit5 = 25562, // Helper->self, no cast, range 24-30 donut

        DragonsRage = 25550, // Boss->self, 4.7s cast, visual
        DragonsRageAOE = 25551, // Helper->players, no cast, range 8 shared aoe
        DimensionalCollapse = 25563, // SerGrinnaux->self, 8.0s cast, visual (growing void zones)
        DimensionalCollapseAOE = 25564, // Helper->location, 9.0s cast, range 10 aoe
        SkywardLeap = 25565, // SerIgnasse/SerVellguine/SerPaulecrain->player, no cast, range 24 aoe on player with blue mark
        Conviction1 = 25566, // SerHermenost->self, 8.2s cast, visual towers
        Conviction1AOE = 25567, // Helper->location, 11.0s cast, range 3 aoe, soaked towers
        EternalConviction = 25568, // Helper->self, no cast, raidwide from unsoaked towers
        HolyShieldBash = 25297, // SerJanlenoux/SerAdelphel->tethered player, no cast, width 8 rect tankbuster
        HolyShieldBashAOE = 25579, // Helper->self, no cast, range 6 ??-degree cone, ??
        HolyBladedanceVisual = 25298, // SerJanlenoux/SerAdelphel->self, no cast, visual
        HolyBladedanceAOE = 25299, // Helper->self, no cast, range 16 90-degree cone aoe (follows tankbuster, multiple hits)

        AncientQuaga = 25542, // Boss->self, 6.0s cast, raidwide
        HeavenlyHeel = 25543, // Boss->player, 4.0s cast, tankbuster forcing tankswap

        SanctityofTheWard = 25569, // Boss->self, 4.0s cast, visual
        DragonsGaze = 25552, // Boss->self, 4.0s cast, visual
        DragonsGazeAOE = 25553, // Helper->self, no cast, face away from caster
        DragonsGlory = 25554, // Helper->self, no cast, face away from caster
        ShiningBlade = 25570, // SerAdelphel/SerJanlenoux->location, no cast, half-width 3 rect (?) charge
        SacredSever = 25571, // SerZephirin->players, no cast, range 6 shared aoe
        BrightFlare = 25295, // Brightsphere->self, 1.0s cast, range 9 aoe

        HiemalStorm = 25574, // SerHaumeric->self, 7.0s cast, visual
        HiemalStormAOE = 25575, // Helper->players, no cast, range 7 aoe, baited at 4 dd or tanks/healers
        HeavensStake = 28590, // SerCharibert->self, 7.0s cast, visual
        HeavensStakeAOE = 28591, // Helper->location, 7.5s cast, range 7 aoe (at four intercardinals)
        HeavensStakeDonut = 28592, // Helper->self, 7.5s cast, range 15?-30 donut aoe
        Conviction2 = 29563, // SerHermenost->self, 9.2s cast, visual
        Conviction2AOE = 29564, // Helper->location, 12.0s cast, range 3 aoe, soaked towers
        HolyComet = 25576, // SerNoudenet->self, 12.0s cast, visual
        HolyCometAOE = 25577, // HolyComet->self, no cast, range 20 aoe on comet drop
        HolyImpact = 25578, // HolyComet->self, no cast, raidwide on comet fail
        FaithUnmoving = 25308, // SerGrinnaux->self, 4.0s cast, knockback 16
        Conviction3 = 28650, // SerHermenost->self, 8.2s cast, visual
        Conviction3AOE = 28651, // Helper->location, 11.0s cast, range 3 aoe, soaked towers

        UltimateEnd = 25533, // Boss->self, no cast, visual
        UltimateEndAOE = 25534, // Helper->self, no cast, raidwide
    };

    public enum SID : uint
    {
        None = 0,
    }

    public enum TetherID : uint
    {
        None = 0,
        HolyShieldBash = 84, // SerJanlenoux/SerAdelphel->player
    }

    public enum IconID : uint
    {
        None = 0,
        SacredSever1 = 50, // player
        SacredSever2 = 51, // player
        SkywardLeap = 330, // player
        Prey = 285, // player
    }
}