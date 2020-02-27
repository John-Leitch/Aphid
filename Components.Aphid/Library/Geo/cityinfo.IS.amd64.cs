
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
                                    public const string Country = "IS";
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
                            
                                        var cur = (Math.Abs(65.75658 - lat) + Math.Abs(-14.82777 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(66.15198 - lat) + Math.Abs(-18.90815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.26008 - lat) + Math.Abs(-14.00577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.74611 - lat) + Math.Abs(-19.63944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.06722 - lat) + Math.Abs(-18.64399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.14819 - lat) + Math.Abs(-13.68368 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.04148 - lat) + Math.Abs(-17.33834 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.25388 - lat) + Math.Abs(-15.21212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.07306 - lat) + Math.Abs(-14.01525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.26687 - lat) + Math.Abs(-14.39485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.97018 - lat) + Math.Abs(-18.52861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.93128 - lat) + Math.Abs(-14.0189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.03164 - lat) + Math.Abs(-14.21832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.68353 - lat) + Math.Abs(-18.0878 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.9816 - lat) + Math.Abs(-22.38473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.44273 - lat) + Math.Abs(-20.27339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.59783 - lat) + Math.Abs(-23.99596 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.85591 - lat) + Math.Abs(-21.38337 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.07537 - lat) + Math.Abs(-22.72977 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.93311 - lat) + Math.Abs(-20.99712 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.03762 - lat) + Math.Abs(-22.70799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.13548 - lat) + Math.Abs(-21.89541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.89429 - lat) + Math.Abs(-23.70918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.15309 - lat) + Math.Abs(-21.99499 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.16667 - lat) + Math.Abs(-21.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.11234 - lat) + Math.Abs(-21.91298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.00492 - lat) + Math.Abs(-22.56242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.07475 - lat) + Math.Abs(-23.13498 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.75069 - lat) + Math.Abs(-20.22454 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.00039 - lat) + Math.Abs(-21.18602 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.39711 - lat) + Math.Abs(-20.94346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.82319 - lat) + Math.Abs(-20.30248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.8348 - lat) + Math.Abs(-20.40084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.0671 - lat) + Math.Abs(-21.93774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.92427 - lat) + Math.Abs(-23.26313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.83849 - lat) + Math.Abs(-22.43931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.07055 - lat) + Math.Abs(-22.6513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.08865 - lat) + Math.Abs(-21.92298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.86323 - lat) + Math.Abs(-21.14915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.1 - lat) + Math.Abs(-22.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.53834 - lat) + Math.Abs(-21.92064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(66.15917 - lat) + Math.Abs(-23.24941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.65932 - lat) + Math.Abs(-20.28083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.32179 - lat) + Math.Abs(-22.0749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(64.24058 - lat) + Math.Abs(-21.8367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(65.72159 - lat) + Math.Abs(-17.37352 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(63.99813 - lat) + Math.Abs(-22.56111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vopnafjörður", "38", 65.75658, -14.82777);
case 1: return new CityInfo("Siglufjörður", "40", 66.15198, -18.90815);
case 2: return new CityInfo("Seyðisfjörður", "38", 65.26008, -14.00577);
case 3: return new CityInfo("Sauðárkrókur", "41", 65.74611, -19.63944);
case 4: return new CityInfo("Ólafsfjörður", "40", 66.06722, -18.64399);
case 5: return new CityInfo("Neskaupstaður", "38", 65.14819, -13.68368);
case 6: return new CityInfo("Húsavík", "40", 66.04148, -17.33834);
case 7: return new CityInfo("Höfn", "38", 64.25388, -15.21212);
case 8: return new CityInfo("Eskifjörður", "38", 65.07306, -14.01525);
case 9: return new CityInfo("Egilsstaðir", "38", 65.26687, -14.39485);
case 10: return new CityInfo("Dalvík", "40", 65.97018, -18.52861);
case 11: return new CityInfo("Fáskrúðsfjörður", "38", 64.93128, -14.0189);
case 12: return new CityInfo("Reyðarfjörður", "38", 65.03164, -14.21832);
case 13: return new CityInfo("Akureyri", "40", 65.68353, -18.0878);
case 14: return new CityInfo("Vogar", "43", 63.9816, -22.38473);
case 15: return new CityInfo("Vestmannaeyjar", "42", 63.44273, -20.27339);
case 16: return new CityInfo("Patreksfjörður", "44", 65.59783, -23.99596);
case 17: return new CityInfo("Þorlákshöfn", "42", 63.85591, -21.38337);
case 18: return new CityInfo("Stykkishólmur", "45", 65.07537, -22.72977);
case 19: return new CityInfo("Selfoss", "42", 63.93311, -20.99712);
case 20: return new CityInfo("Sandgerði", "43", 64.03762, -22.70799);
case 21: return new CityInfo("Reykjavík", "39", 64.13548, -21.89541);
case 22: return new CityInfo("Ólafsvík", "45", 64.89429, -23.70918);
case 23: return new CityInfo("Seltjarnarnes", "39", 64.15309, -21.99499);
case 24: return new CityInfo("Mosfellsbær", "39", 64.16667, -21.7);
case 25: return new CityInfo("Kópavogur", "39", 64.11234, -21.91298);
case 26: return new CityInfo("Keflavík", "43", 64.00492, -22.56242);
case 27: return new CityInfo("Ísafjörður", "44", 66.07475, -23.13498);
case 28: return new CityInfo("Hvolsvöllur", "42", 63.75069, -20.22454);
case 29: return new CityInfo("Hveragerði", "42", 64.00039, -21.18602);
case 30: return new CityInfo("Hvammstangi", "41", 65.39711, -20.94346);
case 31: return new CityInfo("Skagaströnd", "41", 65.82319, -20.30248);
case 32: return new CityInfo("Hella", "42", 63.8348, -20.40084);
case 33: return new CityInfo("Hafnarfjörður", "39", 64.0671, -21.93774);
case 34: return new CityInfo("Grundarfjörður", "45", 64.92427, -23.26313);
case 35: return new CityInfo("Grindavík", "43", 63.83849, -22.43931);
case 36: return new CityInfo("Garður", "43", 64.07055, -22.6513);
case 37: return new CityInfo("Garðabær", "39", 64.08865, -21.92298);
case 38: return new CityInfo("Eyrarbakki", "42", 63.86323, -21.14915);
case 39: return new CityInfo("Álftanes", "39", 64.1, -22.01667);
case 40: return new CityInfo("Borgarnes", "45", 64.53834, -21.92064);
case 41: return new CityInfo("Bolungarvík", "44", 66.15917, -23.24941);
case 42: return new CityInfo("Blönduós", "41", 65.65932, -20.28083);
case 43: return new CityInfo("Akranes", "45", 64.32179, -22.0749);
case 44: return new CityInfo("Grundarhverfi", "39", 64.24058, -21.8367);
case 45: return new CityInfo("Laugar", "40", 65.72159, -17.37352);
default: return new CityInfo("Reykjanesbær", "43", 63.99813, -22.56111);

                                    }                                        
                                }
                            
                        }
                    }
                