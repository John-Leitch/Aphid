
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
                                    public const string Country = "MU";
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
                            
                                        var cur = (Math.Abs(-20.23417 - lat) + Math.Abs(57.55476 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-20.29806 - lat) + Math.Abs(57.47833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.0576 - lat) + Math.Abs(57.55025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.03018 - lat) + Math.Abs(57.60219 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.12611 - lat) + Math.Abs(57.52444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.32556 - lat) + Math.Abs(57.37056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.50972 - lat) + Math.Abs(57.50528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.51667 - lat) + Math.Abs(57.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.2907 - lat) + Math.Abs(57.68779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.2175 - lat) + Math.Abs(57.52083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.22639 - lat) + Math.Abs(57.63639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.36417 - lat) + Math.Abs(57.63833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.496 - lat) + Math.Abs(57.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.07199 - lat) + Math.Abs(57.56833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.40028 - lat) + Math.Abs(57.59667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.01861 - lat) + Math.Abs(57.64472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.11111 - lat) + Math.Abs(57.71222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.36028 - lat) + Math.Abs(57.36611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.10306 - lat) + Math.Abs(57.68472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.48528 - lat) + Math.Abs(57.55083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.22 - lat) + Math.Abs(57.7075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.29917 - lat) + Math.Abs(57.77056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.26381 - lat) + Math.Abs(57.4791 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.2479 - lat) + Math.Abs(57.59737 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.24472 - lat) + Math.Abs(57.61222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.16306 - lat) + Math.Abs(57.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.16194 - lat) + Math.Abs(57.49889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.42967 - lat) + Math.Abs(57.66968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.065 - lat) + Math.Abs(57.5725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.02022 - lat) + Math.Abs(57.62296 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.19551 - lat) + Math.Abs(57.44592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.39306 - lat) + Math.Abs(57.365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.10389 - lat) + Math.Abs(57.57028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.19271 - lat) + Math.Abs(57.48826 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28778 - lat) + Math.Abs(57.73097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.37056 - lat) + Math.Abs(57.56111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.14056 - lat) + Math.Abs(57.55306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.40861 - lat) + Math.Abs(57.61361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.09028 - lat) + Math.Abs(57.63028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28538 - lat) + Math.Abs(57.65865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.21889 - lat) + Math.Abs(57.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.31907 - lat) + Math.Abs(57.57016 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.26972 - lat) + Math.Abs(57.63194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.40806 - lat) + Math.Abs(57.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.14306 - lat) + Math.Abs(57.56222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.18972 - lat) + Math.Abs(57.66111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.24476 - lat) + Math.Abs(57.56188 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.31417 - lat) + Math.Abs(57.76444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28611 - lat) + Math.Abs(57.77583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.00639 - lat) + Math.Abs(57.66083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.01816 - lat) + Math.Abs(57.58015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.41889 - lat) + Math.Abs(57.54417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.03841 - lat) + Math.Abs(57.65055 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.04732 - lat) + Math.Abs(57.584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.27417 - lat) + Math.Abs(57.36306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.06972 - lat) + Math.Abs(57.64194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.31628 - lat) + Math.Abs(57.52594 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.19111 - lat) + Math.Abs(57.55722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.26389 - lat) + Math.Abs(57.70611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.48722 - lat) + Math.Abs(57.46556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.48222 - lat) + Math.Abs(57.46611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.4225 - lat) + Math.Abs(57.38389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.18972 - lat) + Math.Abs(57.71444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.28694 - lat) + Math.Abs(57.40722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.98417 - lat) + Math.Abs(57.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.21472 - lat) + Math.Abs(57.61611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.46278 - lat) + Math.Abs(57.57889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.23694 - lat) + Math.Abs(57.66333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.16389 - lat) + Math.Abs(57.64667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.17083 - lat) + Math.Abs(57.65639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.36306 - lat) + Math.Abs(57.73111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.25777 - lat) + Math.Abs(57.74976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.41889 - lat) + Math.Abs(57.69528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.23325 - lat) + Math.Abs(57.46609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.25667 - lat) + Math.Abs(57.40611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.20814 - lat) + Math.Abs(57.40766 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.14583 - lat) + Math.Abs(57.67667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.36694 - lat) + Math.Abs(57.60389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.05972 - lat) + Math.Abs(57.62917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.06494 - lat) + Math.Abs(57.52347 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.14889 - lat) + Math.Abs(57.59083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.13083 - lat) + Math.Abs(57.65917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.11167 - lat) + Math.Abs(57.69083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.19806 - lat) + Math.Abs(57.74944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.20151 - lat) + Math.Abs(57.77448 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.21583 - lat) + Math.Abs(57.74556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.22611 - lat) + Math.Abs(57.73611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.34278 - lat) + Math.Abs(57.7575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.34667 - lat) + Math.Abs(57.58861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.24494 - lat) + Math.Abs(57.49163 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.20722 - lat) + Math.Abs(57.43 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.07583 - lat) + Math.Abs(57.60139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.30132 - lat) + Math.Abs(57.59861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.135 - lat) + Math.Abs(57.52111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.11167 - lat) + Math.Abs(57.55389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-20.10556 - lat) + Math.Abs(57.53528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.68333 - lat) + Math.Abs(63.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.69444 - lat) + Math.Abs(63.40833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.60329 - lat) + Math.Abs(59.65851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-10.38803 - lat) + Math.Abs(56.61795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Verdun", "15", -20.23417, 57.55476);
case 1: return new CityInfo("Vacoas", "17", -20.29806, 57.47833);
case 2: return new CityInfo("Triolet", "16", -20.0576, 57.55025);
case 3: return new CityInfo("The Vale", "19", -20.03018, 57.60219);
case 4: return new CityInfo("Terre Rouge", "16", -20.12611, 57.52444);
case 5: return new CityInfo("Tamarin", "12", -20.32556, 57.37056);
case 6: return new CityInfo("Surinam", "20", -20.50972, 57.50528);
case 7: return new CityInfo("Souillac", "20", -20.51667, 57.51667);
case 8: return new CityInfo("Sebastopol", "13", -20.2907, 57.68779);
case 9: return new CityInfo("Saint Pierre", "15", -20.2175, 57.52083);
case 10: return new CityInfo("Saint Julien", "13", -20.22639, 57.63639);
case 11: return new CityInfo("Saint Hubert", "14", -20.36417, 57.63833);
case 12: return new CityInfo("Saint Aubin", "20", -20.496, 57.55);
case 13: return new CityInfo("Morcellement Saint André", "16", -20.07199, 57.56833);
case 14: return new CityInfo("Rose Belle", "14", -20.40028, 57.59667);
case 15: return new CityInfo("Roche Terre", "19", -20.01861, 57.64472);
case 16: return new CityInfo("Roches Noire", "19", -20.11111, 57.71222);
case 17: return new CityInfo("Grande Rivière Noire", "12", -20.36028, 57.36611);
case 18: return new CityInfo("Rivière du Rempart", "19", -20.10306, 57.68472);
case 19: return new CityInfo("Rivière des Anguilles", "20", -20.48528, 57.55083);
case 20: return new CityInfo("Queen Victoria", "13", -20.22, 57.7075);
case 21: return new CityInfo("Quatre Soeurs", "13", -20.29917, 57.77056);
case 22: return new CityInfo("Quatre Bornes", "17", -20.26381, 57.4791);
case 23: return new CityInfo("Quartier Militaire", "15", -20.2479, 57.59737);
case 24: return new CityInfo("Providence", "15", -20.24472, 57.61222);
case 25: return new CityInfo("Poste de Flacq", "13", -20.16306, 57.73056);
case 26: return new CityInfo("Port Louis", "18", -20.16194, 57.49889);
case 27: return new CityInfo("Plaine Magnien", "14", -20.42967, 57.66968);
case 28: return new CityInfo("Plaine des Papayes", "16", -20.065, 57.5725);
case 29: return new CityInfo("Petit Raffray", "19", -20.02022, 57.62296);
case 30: return new CityInfo("Petite Rivière", "12", -20.19551, 57.44592);
case 31: return new CityInfo("Petite Case Noyale", "12", -20.39306, 57.365);
case 32: return new CityInfo("Pamplemousses", "16", -20.10389, 57.57028);
case 33: return new CityInfo("Pailles", "15", -20.19271, 57.48826);
case 34: return new CityInfo("Olivia", "13", -20.28778, 57.73097);
case 35: return new CityInfo("Nouvelle France", "14", -20.37056, 57.56111);
case 36: return new CityInfo("Notre Dame", "16", -20.14056, 57.55306);
case 37: return new CityInfo("New Grove", "14", -20.40861, 57.61361);
case 38: return new CityInfo("Piton", "19", -20.09028, 57.63028);
case 39: return new CityInfo("Montagne Blanche", "00", -20.28538, 57.65865);
case 40: return new CityInfo("Moka", "15", -20.21889, 57.49583);
case 41: return new CityInfo("Midlands", "17", -20.31907, 57.57016);
case 42: return new CityInfo("Melrose", "15", -20.26972, 57.63194);
case 43: return new CityInfo("Mahébourg", "14", -20.40806, 57.7);
case 44: return new CityInfo("Long Mountain", "16", -20.14306, 57.56222);
case 45: return new CityInfo("Lalmatie", "13", -20.18972, 57.66111);
case 46: return new CityInfo("Dagotière", "15", -20.24476, 57.56188);
case 47: return new CityInfo("Grand Sable", "14", -20.31417, 57.76444);
case 48: return new CityInfo("Grande Rivière Sud Est", "13", -20.28611, 57.77583);
case 49: return new CityInfo("Grand Gaube", "19", -20.00639, 57.66083);
case 50: return new CityInfo("Grand Baie", "19", -20.01816, 57.58015);
case 51: return new CityInfo("Grand Bois", "20", -20.41889, 57.54417);
case 52: return new CityInfo("Goodlands", "19", -20.03841, 57.65055);
case 53: return new CityInfo("Fond du Sac", "16", -20.04732, 57.584);
case 54: return new CityInfo("Flic en Flac", "12", -20.27417, 57.36306);
case 55: return new CityInfo("Espérance Trébuchet", "19", -20.06972, 57.64194);
case 56: return new CityInfo("Curepipe", "17", -20.31628, 57.52594);
case 57: return new CityInfo("Crève Coeur", "16", -20.19111, 57.55722);
case 58: return new CityInfo("Clémencia", "13", -20.26389, 57.70611);
case 59: return new CityInfo("Chemin Grenier", "20", -20.48722, 57.46556);
case 60: return new CityInfo("Chamouny", "20", -20.48222, 57.46611);
case 61: return new CityInfo("Chamarel", "12", -20.4225, 57.38389);
case 62: return new CityInfo("Centre de Flacq", "13", -20.18972, 57.71444);
case 63: return new CityInfo("Cascavelle", "12", -20.28694, 57.40722);
case 64: return new CityInfo("Cap Malheureux", "19", -19.98417, 57.61417);
case 65: return new CityInfo("Camp Thorel", "15", -20.21472, 57.61611);
case 66: return new CityInfo("Camp Diable", "20", -20.46278, 57.57889);
case 67: return new CityInfo("Camp de Masque", "13", -20.23694, 57.66333);
case 68: return new CityInfo("Brisée Verdière", "13", -20.16389, 57.64667);
case 69: return new CityInfo("Bon Accueil", "13", -20.17083, 57.65639);
case 70: return new CityInfo("Bois des Amourettes", "14", -20.36306, 57.73111);
case 71: return new CityInfo("Bel Air Rivière Sèche", "13", -20.25777, 57.74976);
case 72: return new CityInfo("Beau Vallon", "14", -20.41889, 57.69528);
case 73: return new CityInfo("Beau Bassin-Rose Hill", "17", -20.23325, 57.46609);
case 74: return new CityInfo("Bambous", "12", -20.25667, 57.40611);
case 75: return new CityInfo("Albion", "12", -20.20814, 57.40766);
case 76: return new CityInfo("Laventure", "13", -20.14583, 57.67667);
case 77: return new CityInfo("Cluny", "14", -20.36694, 57.60389);
case 78: return new CityInfo("Cottage", "19", -20.05972, 57.62917);
case 79: return new CityInfo("Pointe aux Piments", "16", -20.06494, 57.52347);
case 80: return new CityInfo("Congomah", "16", -20.14889, 57.59083);
case 81: return new CityInfo("Amaury", "19", -20.13083, 57.65917);
case 82: return new CityInfo("Plaines des Roches", "19", -20.11167, 57.69083);
case 83: return new CityInfo("Mare La Chaux", "13", -20.19806, 57.74944);
case 84: return new CityInfo("Quatre Cocos", "13", -20.20151, 57.77448);
case 85: return new CityInfo("Camp Ithier", "13", -20.21583, 57.74556);
case 86: return new CityInfo("Ecroignard", "13", -20.22611, 57.73611);
case 87: return new CityInfo("Bambous Virieux", "14", -20.34278, 57.7575);
case 88: return new CityInfo("Bananes", "14", -20.34667, 57.58861);
case 89: return new CityInfo("Ebene", "17", -20.24494, 57.49163);
case 90: return new CityInfo("Gros Cailloux", "12", -20.20722, 57.43);
case 91: return new CityInfo("Mapou", "19", -20.07583, 57.60139);
case 92: return new CityInfo("Dubreuil", "15", -20.30132, 57.59861);
case 93: return new CityInfo("Le Hochet", "16", -20.135, 57.52111);
case 94: return new CityInfo("Calebasses", "16", -20.11167, 57.55389);
case 95: return new CityInfo("Arsenal", "16", -20.10556, 57.53528);
case 96: return new CityInfo("Port Mathurin", "23", -19.68333, 63.41667);
case 97: return new CityInfo("Baie aux Huîtres", "23", -19.69444, 63.40833);
case 98: return new CityInfo("Cargados Carajos", "22", -16.60329, 59.65851);
default: return new CityInfo("Vingt Cinq", "21", -10.38803, 56.61795);

                                    }                                        
                                }
                            
                        }
                    }
                