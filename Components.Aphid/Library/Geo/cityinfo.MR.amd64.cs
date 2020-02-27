
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
                                    public const string Country = "MR";
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
                            
                                        var cur = (Math.Abs(22.73542 - lat) + Math.Abs(-12.47134 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(16.60175 - lat) + Math.Abs(-15.34866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.55644 - lat) + Math.Abs(-11.42715 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.15846 - lat) + Math.Abs(-12.1843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.51378 - lat) + Math.Abs(-15.80503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.08581 - lat) + Math.Abs(-15.9785 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.94188 - lat) + Math.Abs(-17.03842 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.61702 - lat) + Math.Abs(-7.25649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.62073 - lat) + Math.Abs(-11.40208 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.15027 - lat) + Math.Abs(-13.5037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.0105 - lat) + Math.Abs(-13.97102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.463 - lat) + Math.Abs(-12.362 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.64039 - lat) + Math.Abs(-12.49849 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.6614 - lat) + Math.Abs(-9.6149 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(20.5177 - lat) + Math.Abs(-13.04857 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.05314 - lat) + Math.Abs(-13.91312 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(19.74657 - lat) + Math.Abs(-14.38531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.04639 - lat) + Math.Abs(-15.97194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.09894 - lat) + Math.Abs(-15.98848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(18.10808 - lat) + Math.Abs(-15.92666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Zouerate", "11", 22.73542, -12.47134);
case 1: return new CityInfo("Tékane", "06", 16.60175, -15.34866);
case 2: return new CityInfo("Tidjikja", "09", 18.55644, -11.42715);
case 3: return new CityInfo("Sélibaby", "10", 15.15846, -12.1843);
case 4: return new CityInfo("Rosso", "06", 16.51378, -15.80503);
case 5: return new CityInfo("Nouakchott", "", 18.08581, -15.9785);
case 6: return new CityInfo("Nouadhibou", "08", 20.94188, -17.03842);
case 7: return new CityInfo("Néma", "01", 16.61702, -7.25649);
case 8: return new CityInfo("Kiffa", "03", 16.62073, -11.40208);
case 9: return new CityInfo("Kaédi", "04", 16.15027, -13.5037);
case 10: return new CityInfo("’Elb el Jmel", "05", 17.0105, -13.97102);
case 11: return new CityInfo("Chingueṭṭi", "07", 20.463, -12.362);
case 12: return new CityInfo("Barkéwol", "03", 16.64039, -12.49849);
case 13: return new CityInfo("Aioun", "02", 16.6614, -9.6149);
case 14: return new CityInfo("Atar", "07", 20.5177, -13.04857);
case 15: return new CityInfo("Aleg", "05", 17.05314, -13.91312);
case 16: return new CityInfo("Akjoujt", "12", 19.74657, -14.38531);
case 17: return new CityInfo("Arafat", "15", 18.04639, -15.97194);
case 18: return new CityInfo("Tevragh Zeina", "13", 18.09894, -15.98848);
default: return new CityInfo("Dar Naim", "14", 18.10808, -15.92666);

                                    }                                        
                                }
                            
                        }
                    }
                