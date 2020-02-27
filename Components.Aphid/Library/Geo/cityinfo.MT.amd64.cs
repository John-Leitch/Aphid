
                    namespace Components.RoslynJit
                    {
                        using System;
                        using System.Collections.Generic;

                        public static class GeneratedContainer
                        {
                            
                                public readonly struct CityInfo
                                {
                                    public readonly string Name;
                                    public readonly string State;
                                    public const string Country = "MT";
                                    public readonly double Latitude;
                                    public readonly double Longitude;

                                    public CityInfo(
                                        string name,
                                        in string state,
                                        double latitude,
                                        double longitude)
                                    {
                                        Name = name;
                                        State = state;
                                        Latitude = latitude;
                                        Longitude = longitude;
                                    }
                                }
                            
                                public static CityInfo GetClosestCity(double lat, double lng)
                                {
                                    double tmp;
                            
                                        var cur = (Math.Abs(35.84194 - lat) + Math.Abs(14.54306 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(35.83111 - lat) + Math.Abs(14.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85583 - lat) + Math.Abs(14.53306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.07222 - lat) + Math.Abs(14.23583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87194 - lat) + Math.Abs(14.44111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87611 - lat) + Math.Abs(14.535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88556 - lat) + Math.Abs(14.5475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03278 - lat) + Math.Abs(14.25806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05 - lat) + Math.Abs(14.26444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89968 - lat) + Math.Abs(14.5148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89917 - lat) + Math.Abs(14.49444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86583 - lat) + Math.Abs(14.515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9125 - lat) + Math.Abs(14.50194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85556 - lat) + Math.Abs(14.43639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89083 - lat) + Math.Abs(14.47417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.04306 - lat) + Math.Abs(14.21722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86278 - lat) + Math.Abs(14.5075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95064 - lat) + Math.Abs(14.41561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.02444 - lat) + Math.Abs(14.24278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05556 - lat) + Math.Abs(14.20361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.91839 - lat) + Math.Abs(14.48977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83306 - lat) + Math.Abs(14.48472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87306 - lat) + Math.Abs(14.49889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.04444 - lat) + Math.Abs(14.23972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88152 - lat) + Math.Abs(14.39872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.83472 - lat) + Math.Abs(14.45833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87601 - lat) + Math.Abs(14.472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03611 - lat) + Math.Abs(14.30944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89472 - lat) + Math.Abs(14.495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.91361 - lat) + Math.Abs(14.44361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03778 - lat) + Math.Abs(14.29417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.03 - lat) + Math.Abs(14.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89333 - lat) + Math.Abs(14.39889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8925 - lat) + Math.Abs(14.48278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84763 - lat) + Math.Abs(14.46824 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90917 - lat) + Math.Abs(14.42556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.02528 - lat) + Math.Abs(14.295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.92056 - lat) + Math.Abs(14.36639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.95639 - lat) + Math.Abs(14.36222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88694 - lat) + Math.Abs(14.4025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8622 - lat) + Math.Abs(14.56701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87917 - lat) + Math.Abs(14.49528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.85889 - lat) + Math.Abs(14.48861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.8875 - lat) + Math.Abs(14.51694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90414 - lat) + Math.Abs(14.45415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90056 - lat) + Math.Abs(14.44639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84222 - lat) + Math.Abs(14.48528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.04194 - lat) + Math.Abs(14.22667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88917 - lat) + Math.Abs(14.53278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.9225 - lat) + Math.Abs(14.48 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90583 - lat) + Math.Abs(14.48806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89583 - lat) + Math.Abs(14.50833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89222 - lat) + Math.Abs(14.51833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88472 - lat) + Math.Abs(14.48444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84917 - lat) + Math.Abs(14.50306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.84889 - lat) + Math.Abs(14.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.05778 - lat) + Math.Abs(14.22639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.92409 - lat) + Math.Abs(14.45118 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06 - lat) + Math.Abs(14.20889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.06611 - lat) + Math.Abs(14.21833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.02639 - lat) + Math.Abs(14.285 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.87028 - lat) + Math.Abs(14.51333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.86139 - lat) + Math.Abs(14.38222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88556 - lat) + Math.Abs(14.5275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.82583 - lat) + Math.Abs(14.52694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.89722 - lat) + Math.Abs(14.46111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90028 - lat) + Math.Abs(14.455 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.88972 - lat) + Math.Abs(14.4425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.90556 - lat) + Math.Abs(14.47611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(36.0375 - lat) + Math.Abs(14.23611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.93056 - lat) + Math.Abs(14.47639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(35.92517 - lat) + Math.Abs(14.47805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Marsaxlokk", "33", 35.84194, 14.54306);
case 1: return new CityInfo("Żurrieq", "68", 35.83111, 14.47417);
case 2: return new CityInfo("Żejtun", "67", 35.85583, 14.53306);
case 3: return new CityInfo("Żebbuġ", "66", 36.07222, 14.23583);
case 4: return new CityInfo("Haz-Zebbug", "65", 35.87194, 14.44111);
case 5: return new CityInfo("Żabbar", "64", 35.87611, 14.535);
case 6: return new CityInfo("Xgħajra", "63", 35.88556, 14.5475);
case 7: return new CityInfo("Xewkija", "62", 36.03278, 14.25806);
case 8: return new CityInfo("Xagħra", "61", 36.05, 14.26444);
case 9: return new CityInfo("Valletta", "60", 35.89968, 14.5148);
case 10: return new CityInfo("Ta’ Xbiex", "59", 35.89917, 14.49444);
case 11: return new CityInfo("Tarxien", "58", 35.86583, 14.515);
case 12: return new CityInfo("Sliema", "56", 35.9125, 14.50194);
case 13: return new CityInfo("Siġġiewi", "55", 35.85556, 14.43639);
case 14: return new CityInfo("Santa Venera", "53", 35.89083, 14.47417);
case 15: return new CityInfo("Saint Lucia", "51", 36.04306, 14.21722);
case 16: return new CityInfo("Santa Luċija", "51", 35.86278, 14.5075);
case 17: return new CityInfo("San Pawl il-Baħar", "52", 35.95064, 14.41561);
case 18: return new CityInfo("Sannat", "54", 36.02444, 14.24278);
case 19: return new CityInfo("San Lawrenz", "50", 36.05556, 14.20361);
case 20: return new CityInfo("San Ġiljan", "49", 35.91839, 14.48977);
case 21: return new CityInfo("Safi", "47", 35.83306, 14.48472);
case 22: return new CityInfo("Paola", "39", 35.87306, 14.49889);
case 23: return new CityInfo("Victoria", "46", 36.04444, 14.23972);
case 24: return new CityInfo("Rabat", "45", 35.88152, 14.39872);
case 25: return new CityInfo("Qrendi", "44", 35.83472, 14.45833);
case 26: return new CityInfo("Qormi", "43", 35.87601, 14.472);
case 27: return new CityInfo("Qala", "42", 36.03611, 14.30944);
case 28: return new CityInfo("Pietà", "41", 35.89472, 14.495);
case 29: return new CityInfo("Naxxar", "38", 35.91361, 14.44361);
case 30: return new CityInfo("Nadur", "37", 36.03778, 14.29417);
case 31: return new CityInfo("Munxar", "36", 36.03, 14.23333);
case 32: return new CityInfo("Imtarfa", "24", 35.89333, 14.39889);
case 33: return new CityInfo("Imsida", "23", 35.8925, 14.48278);
case 34: return new CityInfo("Mqabba", "22", 35.84763, 14.46824);
case 35: return new CityInfo("Mosta", "35", 35.90917, 14.42556);
case 36: return new CityInfo("Mġarr", "21", 36.02528, 14.295);
case 37: return new CityInfo("Imġarr", "21", 35.92056, 14.36639);
case 38: return new CityInfo("Mellieħa", "34", 35.95639, 14.36222);
case 39: return new CityInfo("Imdina", "20", 35.88694, 14.4025);
case 40: return new CityInfo("Marsaskala", "32", 35.8622, 14.56701);
case 41: return new CityInfo("Marsa", "31", 35.87917, 14.49528);
case 42: return new CityInfo("Luqa", "30", 35.85889, 14.48861);
case 43: return new CityInfo("Senglea", "25", 35.8875, 14.51694);
case 44: return new CityInfo("L-Iklin", "19", 35.90414, 14.45415);
case 45: return new CityInfo("Lija", "29", 35.90056, 14.44639);
case 46: return new CityInfo("Kirkop", "28", 35.84222, 14.48528);
case 47: return new CityInfo("Kerċem", "27", 36.04194, 14.22667);
case 48: return new CityInfo("Kalkara", "26", 35.88917, 14.53278);
case 49: return new CityInfo("Swieqi", "57", 35.9225, 14.48);
case 50: return new CityInfo("Gżira", "17", 35.90583, 14.48806);
case 51: return new CityInfo("Floriana", "09", 35.89583, 14.50833);
case 52: return new CityInfo("Vittoriosa", "03", 35.89222, 14.51833);
case 53: return new CityInfo("Ħamrun", "18", 35.88472, 14.48444);
case 54: return new CityInfo("Gudja", "16", 35.84917, 14.50306);
case 55: return new CityInfo("Għaxaq", "15", 35.84889, 14.51667);
case 56: return new CityInfo("Għasri", "14", 36.05778, 14.22639);
case 57: return new CityInfo("Hal Gharghur", "13", 35.92409, 14.45118);
case 58: return new CityInfo("Għarb", "12", 36.06, 14.20889);
case 59: return new CityInfo("Għammar", "14", 36.06611, 14.21833);
case 60: return new CityInfo("Għajnsielem", "11", 36.02639, 14.285);
case 61: return new CityInfo("Fgura", "08", 35.87028, 14.51333);
case 62: return new CityInfo("Dingli", "07", 35.86139, 14.38222);
case 63: return new CityInfo("Cospicua", "06", 35.88556, 14.5275);
case 64: return new CityInfo("Birżebbuġa", "05", 35.82583, 14.52694);
case 65: return new CityInfo("Birkirkara", "04", 35.89722, 14.46111);
case 66: return new CityInfo("Balzan", "02", 35.90028, 14.455);
case 67: return new CityInfo("Attard", "01", 35.88972, 14.4425);
case 68: return new CityInfo("Saint John", "48", 35.90556, 14.47611);
case 69: return new CityInfo("Fontana", "10", 36.0375, 14.23611);
case 70: return new CityInfo("Pembroke", "40", 35.93056, 14.47639);
default: return new CityInfo("Sprachcaffe", "40", 35.92517, 14.47805);

                                    }                                        
                                }
                            
                        }
                    }
                