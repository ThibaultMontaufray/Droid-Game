namespace Droid_Game
{
    using System;

    [Serializable]
    public enum CARDCOLOR
    {
        TREFLE,
        CARREAU,
        COEUR,
        PIQUE
    }
    [Serializable]
    public enum CARDVALUE
    {
        DEUX = 2,
        TROIS = 3,
        QUATRE = 4,
        CINQ = 5,
        SIX = 6,
        SEPT = 7,
        HUIT = 8,
        NEUF = 9,
        DIX = 10,
        VALET = 11,
        DAME = 12,
        ROI = 13,
        AS = 14
    }
    [Serializable]
    public enum COMBINAISON
    {
        QUINTEFLUSHROYALE = 9,
        QUINTEFLUSH = 8,
        CARRE = 7,
        FULL = 6,
        COULEUR = 5,
        QUINTE = 4,
        BRELAN = 3,
        DOUBLEPAIRE = 2,
        PAIRE = 1,
        CARTEHAUTE = 0
    }
}