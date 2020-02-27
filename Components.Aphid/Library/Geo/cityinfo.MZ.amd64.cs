
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
                                    public const string Country = "MZ";
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
                            
                                        var cur = (Math.Abs(-25.05194 - lat) + Math.Abs(33.64417 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(-19.60944 - lat) + Math.Abs(34.74306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-18.58111 - lat) + Math.Abs(36.45861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.02694 - lat) + Math.Abs(33.09889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.15639 - lat) + Math.Abs(33.58667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.44278 - lat) + Math.Abs(31.99528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-17.87861 - lat) + Math.Abs(36.88833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-12.97395 - lat) + Math.Abs(40.51775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.11646 - lat) + Math.Abs(39.2666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.56257 - lat) + Math.Abs(40.68538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.12556 - lat) + Math.Abs(38.99972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-11.31667 - lat) + Math.Abs(40.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-15.03417 - lat) + Math.Abs(40.73583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.85972 - lat) + Math.Abs(35.34722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.96222 - lat) + Math.Abs(32.45889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.96553 - lat) + Math.Abs(32.58322 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-25.40222 - lat) + Math.Abs(32.80722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.3525 - lat) + Math.Abs(35.65056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-13.31278 - lat) + Math.Abs(35.24056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-23.865 - lat) + Math.Abs(35.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.80306 - lat) + Math.Abs(36.53722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.53333 - lat) + Math.Abs(32.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.11639 - lat) + Math.Abs(33.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-24.68667 - lat) + Math.Abs(33.53056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-19.84361 - lat) + Math.Abs(34.83889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-16.2325 - lat) + Math.Abs(39.90861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(-14.87056 - lat) + Math.Abs(37.00444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Xai-Xai", "02", -25.05194, 33.64417);
case 1: return new CityInfo("Dondo", "05", -19.60944, 34.74306);
case 2: return new CityInfo("Chinde", "09", -18.58111, 36.45861);
case 3: return new CityInfo("Macia", "02", -25.02694, 33.09889);
case 4: return new CityInfo("Tete", "08", -16.15639, 33.58667);
case 5: return new CityInfo("Ressano Garcia", "04", -25.44278, 31.99528);
case 6: return new CityInfo("Quelimane", "09", -17.87861, 36.88833);
case 7: return new CityInfo("Pemba", "01", -12.97395, 40.51775);
case 8: return new CityInfo("Nampula", "06", -15.11646, 39.2666);
case 9: return new CityInfo("Nacala", "06", -14.56257, 40.68538);
case 10: return new CityInfo("Montepuez", "01", -13.12556, 38.99972);
case 11: return new CityInfo("Mocímboa", "01", -11.31667, 40.35);
case 12: return new CityInfo("Ilha de Moçambique", "06", -15.03417, 40.73583);
case 13: return new CityInfo("Maxixe", "03", -23.85972, 35.34722);
case 14: return new CityInfo("Matola", "04", -25.96222, 32.45889);
case 15: return new CityInfo("Maputo", "11", -25.96553, 32.58322);
case 16: return new CityInfo("Manhiça", "04", -25.40222, 32.80722);
case 17: return new CityInfo("Mandimba", "07", -14.3525, 35.65056);
case 18: return new CityInfo("Lichinga", "07", -13.31278, 35.24056);
case 19: return new CityInfo("Inhambane", "03", -23.865, 35.38333);
case 20: return new CityInfo("Cuamba", "07", -14.80306, 36.53722);
case 21: return new CityInfo("Chokwé", "02", -24.53333, 32.98333);
case 22: return new CityInfo("Chimoio", "10", -19.11639, 33.48333);
case 23: return new CityInfo("Chibuto", "02", -24.68667, 33.53056);
case 24: return new CityInfo("Beira", "05", -19.84361, 34.83889);
case 25: return new CityInfo("António Enes", "06", -16.2325, 39.90861);
default: return new CityInfo("Mutuáli", "06", -14.87056, 37.00444);

                                    }                                        
                                }
                            
                        }
                    }
                