
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
                                    public const string Country = "VE";
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
                            
                                        var cur = (Math.Abs(11.03333 - lat) + Math.Abs(-63.86278 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(10.43337 - lat) + Math.Abs(-66.98313 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.11347 - lat) + Math.Abs(-68.06783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15204 - lat) + Math.Abs(-65.01732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.42958 - lat) + Math.Abs(-64.46428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.44329 - lat) + Math.Abs(-71.30139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43525 - lat) + Math.Abs(-69.99633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.50005 - lat) + Math.Abs(-71.84446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.57084 - lat) + Math.Abs(-70.37524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.66435 - lat) + Math.Abs(-70.23216 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5931 - lat) + Math.Abs(-70.2261 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.37706 - lat) + Math.Abs(-71.78398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35029 - lat) + Math.Abs(-65.32452 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.59703 - lat) + Math.Abs(-68.67328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.08081 - lat) + Math.Abs(-69.1242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.96985 - lat) + Math.Abs(-68.54648 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.56839 - lat) + Math.Abs(-62.82628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.03863 - lat) + Math.Abs(-67.48938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33186 - lat) + Math.Abs(-69.11968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23704 - lat) + Math.Abs(-69.4183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.21554 - lat) + Math.Abs(-66.00734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.90999 - lat) + Math.Abs(-65.67405 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.31778 - lat) + Math.Abs(-70.60361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16202 - lat) + Math.Abs(-68.00765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.2007 - lat) + Math.Abs(-70.25597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91857 - lat) + Math.Abs(-72.44708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.99432 - lat) + Math.Abs(-62.35202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15847 - lat) + Math.Abs(-69.00782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0162 - lat) + Math.Abs(-62.40561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26648 - lat) + Math.Abs(-72.06432 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.22856 - lat) + Math.Abs(-67.47421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.5748 - lat) + Math.Abs(-63.10751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.29861 - lat) + Math.Abs(-61.50497 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05806 - lat) + Math.Abs(-62.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.27304 - lat) + Math.Abs(-65.77153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.97003 - lat) + Math.Abs(-71.27277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.79006 - lat) + Math.Abs(-68.32564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36583 - lat) + Math.Abs(-70.43694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.33015 - lat) + Math.Abs(-71.75277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50015 - lat) + Math.Abs(-70.08056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03457 - lat) + Math.Abs(-71.01412 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.49946 - lat) + Math.Abs(-69.259 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91861 - lat) + Math.Abs(-68.30472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.69894 - lat) + Math.Abs(-68.43273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98224 - lat) + Math.Abs(-70.73926 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25927 - lat) + Math.Abs(-71.36343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00525 - lat) + Math.Abs(-62.64493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8188 - lat) + Math.Abs(-72.22427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6317 - lat) + Math.Abs(-71.07833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.16206 - lat) + Math.Abs(-63.5654 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.23062 - lat) + Math.Abs(-70.82198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.57112 - lat) + Math.Abs(-69.70172 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08656 - lat) + Math.Abs(-71.85595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.14514 - lat) + Math.Abs(-72.07332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.78129 - lat) + Math.Abs(-69.1633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.86052 - lat) + Math.Abs(-70.6948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7901 - lat) + Math.Abs(-71.07084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23291 - lat) + Math.Abs(-66.66474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.44033 - lat) + Math.Abs(-69.70105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.53642 - lat) + Math.Abs(-71.51104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.81556 - lat) + Math.Abs(-65.3225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.71412 - lat) + Math.Abs(-71.46466 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30494 - lat) + Math.Abs(-66.65998 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10155 - lat) + Math.Abs(-69.77752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.63163 - lat) + Math.Abs(-70.80837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.26241 - lat) + Math.Abs(-69.89795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.60226 - lat) + Math.Abs(-61.11025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.82062 - lat) + Math.Abs(-71.46572 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39925 - lat) + Math.Abs(-71.64082 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.81919 - lat) + Math.Abs(-69.27679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18 - lat) + Math.Abs(-67.51184 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.92408 - lat) + Math.Abs(-68.91745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.60745 - lat) + Math.Abs(-63.60938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81348 - lat) + Math.Abs(-71.17788 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.47135 - lat) + Math.Abs(-71.01213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.06828 - lat) + Math.Abs(-63.92239 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3056 - lat) + Math.Abs(-64.65478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.11697 - lat) + Math.Abs(-72.02174 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6422 - lat) + Math.Abs(-72.27694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35018 - lat) + Math.Abs(-71.85114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27585 - lat) + Math.Abs(-70.11027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.67813 - lat) + Math.Abs(-68.97278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3067 - lat) + Math.Abs(-70.59042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.02667 - lat) + Math.Abs(-70.00861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.78131 - lat) + Math.Abs(-63.99675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.24929 - lat) + Math.Abs(-68.84427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21302 - lat) + Math.Abs(-67.42365 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.74004 - lat) + Math.Abs(-64.54937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.12034 - lat) + Math.Abs(-69.68397 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.32665 - lat) + Math.Abs(-66.05402 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.91152 - lat) + Math.Abs(-67.35381 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.17203 - lat) + Math.Abs(-68.4128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03125 - lat) + Math.Abs(-72.26053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.01422 - lat) + Math.Abs(-63.94383 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30125 - lat) + Math.Abs(-65.99053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88724 - lat) + Math.Abs(-64.16512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.59973 - lat) + Math.Abs(-63.32852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26061 - lat) + Math.Abs(-67.79348 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17793 - lat) + Math.Abs(-66.74649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.55363 - lat) + Math.Abs(-71.70364 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.04564 - lat) + Math.Abs(-67.69934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.33991 - lat) + Math.Abs(-68.74247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26057 - lat) + Math.Abs(-67.95363 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.76694 - lat) + Math.Abs(-72.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.00169 - lat) + Math.Abs(-67.01464 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(1.92027 - lat) + Math.Abs(-67.06089 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00098 - lat) + Math.Abs(-71.92683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.66124 - lat) + Math.Abs(-68.58268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.75209 - lat) + Math.Abs(-69.6524 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.81454 - lat) + Math.Abs(-72.4431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.38853 - lat) + Math.Abs(-66.95179 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44198 - lat) + Math.Abs(-63.78874 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.11914 - lat) + Math.Abs(-63.72535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96378 - lat) + Math.Abs(-68.43384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.75234 - lat) + Math.Abs(-69.93351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.4018 - lat) + Math.Abs(-70.79812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.12111 - lat) + Math.Abs(-69.03639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43494 - lat) + Math.Abs(-70.77495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.70131 - lat) + Math.Abs(-72.35569 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.3258 - lat) + Math.Abs(-72.31343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.31899 - lat) + Math.Abs(-65.97751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.6977 - lat) + Math.Abs(-63.10871 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.9795 - lat) + Math.Abs(-63.21991 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.92866 - lat) + Math.Abs(-69.6201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91659 - lat) + Math.Abs(-72.0138 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70015 - lat) + Math.Abs(-70.31941 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.69152 - lat) + Math.Abs(-70.19918 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.90123 - lat) + Math.Abs(-64.0969 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.61759 - lat) + Math.Abs(-71.49164 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.69131 - lat) + Math.Abs(-63.60921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.65806 - lat) + Math.Abs(-70.215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.05896 - lat) + Math.Abs(-65.03698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21382 - lat) + Math.Abs(-64.6328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.07281 - lat) + Math.Abs(-69.30246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.48614 - lat) + Math.Abs(-69.35319 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.47306 - lat) + Math.Abs(-68.0125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.66049 - lat) + Math.Abs(-67.58343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.94788 - lat) + Math.Abs(-69.92306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.96249 - lat) + Math.Abs(-71.60754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.9152 - lat) + Math.Abs(-70.65919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01909 - lat) + Math.Abs(-71.76595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.95771 - lat) + Math.Abs(-63.86971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.36648 - lat) + Math.Abs(-69.13807 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0395 - lat) + Math.Abs(-65.03037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.37083 - lat) + Math.Abs(-69.21028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.47679 - lat) + Math.Abs(-66.80786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.02012 - lat) + Math.Abs(-70.11997 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.9168 - lat) + Math.Abs(-71.05934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.971 - lat) + Math.Abs(-62.252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84357 - lat) + Math.Abs(-64.71053 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.43326 - lat) + Math.Abs(-69.94728 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.10783 - lat) + Math.Abs(-63.85537 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.94109 - lat) + Math.Abs(-69.46021 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.00122 - lat) + Math.Abs(-63.79297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.41037 - lat) + Math.Abs(-70.50116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.44519 - lat) + Math.Abs(-70.47556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17389 - lat) + Math.Abs(-67.54194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.8373 - lat) + Math.Abs(-72.22802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.23333 - lat) + Math.Abs(-66.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.29572 - lat) + Math.Abs(-69.45434 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.62168 - lat) + Math.Abs(-67.29047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.59714 - lat) + Math.Abs(-65.1935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.1182 - lat) + Math.Abs(-66.77513 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.46127 - lat) + Math.Abs(-67.76872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.60701 - lat) + Math.Abs(-70.10489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.14007 - lat) + Math.Abs(-71.09143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15039 - lat) + Math.Abs(-68.56478 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.62026 - lat) + Math.Abs(-66.73833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25604 - lat) + Math.Abs(-68.01649 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.41667 - lat) + Math.Abs(-71.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74921 - lat) + Math.Abs(-70.91978 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.39182 - lat) + Math.Abs(-70.59061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48715 - lat) + Math.Abs(-68.20078 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.18821 - lat) + Math.Abs(-70.81229 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.21313 - lat) + Math.Abs(-68.32669 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1602 - lat) + Math.Abs(-68.72604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15077 - lat) + Math.Abs(-68.39325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.95655 - lat) + Math.Abs(-72.24299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58972 - lat) + Math.Abs(-71.15611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.68091 - lat) + Math.Abs(-71.03609 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.00194 - lat) + Math.Abs(-70.30139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.7188 - lat) + Math.Abs(-67.56046 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.41584 - lat) + Math.Abs(-65.19034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.44789 - lat) + Math.Abs(-63.90161 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.29532 - lat) + Math.Abs(-67.7177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23535 - lat) + Math.Abs(-67.59113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66663 - lat) + Math.Abs(-71.61245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.645 - lat) + Math.Abs(-70.41985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.74085 - lat) + Math.Abs(-64.71047 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.36556 - lat) + Math.Abs(-66.13391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.5945 - lat) + Math.Abs(-66.95624 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60508 - lat) + Math.Abs(-66.89745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.06077 - lat) + Math.Abs(-72.55212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.34447 - lat) + Math.Abs(-67.04325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.02588 - lat) + Math.Abs(-69.24166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18932 - lat) + Math.Abs(-67.93828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.49389 - lat) + Math.Abs(-66.82863 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.92978 - lat) + Math.Abs(-72.24731 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35654 - lat) + Math.Abs(-68.69221 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.32709 - lat) + Math.Abs(-69.63093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.12489 - lat) + Math.Abs(-71.46041 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.82893 - lat) + Math.Abs(-72.31942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.73109 - lat) + Math.Abs(-70.18072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.22677 - lat) + Math.Abs(-67.33122 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.46077 - lat) + Math.Abs(-69.5657 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.82391 - lat) + Math.Abs(-69.99581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21573 - lat) + Math.Abs(-67.76653 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.53724 - lat) + Math.Abs(-68.63022 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25416 - lat) + Math.Abs(-67.17333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.11037 - lat) + Math.Abs(-66.39607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61867 - lat) + Math.Abs(-66.38194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.15522 - lat) + Math.Abs(-70.57702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.32025 - lat) + Math.Abs(-71.2721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39419 - lat) + Math.Abs(-69.82358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.13008 - lat) + Math.Abs(-71.25946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50457 - lat) + Math.Abs(-71.3894 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60156 - lat) + Math.Abs(-66.93293 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.17453 - lat) + Math.Abs(-65.54517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.06302 - lat) + Math.Abs(-69.71287 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61919 - lat) + Math.Abs(-71.83814 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4119 - lat) + Math.Abs(-71.68919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10023 - lat) + Math.Abs(-70.90671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.59708 - lat) + Math.Abs(-70.32056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.71364 - lat) + Math.Abs(-71.44421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.08172 - lat) + Math.Abs(-63.96549 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.07446 - lat) + Math.Abs(-68.85583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.57006 - lat) + Math.Abs(-62.58204 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48287 - lat) + Math.Abs(-66.10096 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.57721 - lat) + Math.Abs(-62.29841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.08344 - lat) + Math.Abs(-67.77799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.00077 - lat) + Math.Abs(-67.39732 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.474 - lat) + Math.Abs(-66.54241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47702 - lat) + Math.Abs(-61.89666 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.47027 - lat) + Math.Abs(-66.61934 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.15405 - lat) + Math.Abs(-71.73562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23453 - lat) + Math.Abs(-64.59708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.69625 - lat) + Math.Abs(-69.20832 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.04183 - lat) + Math.Abs(-69.74206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.26638 - lat) + Math.Abs(-68.81986 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.53508 - lat) + Math.Abs(-68.04923 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.22609 - lat) + Math.Abs(-67.877 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.47016 - lat) + Math.Abs(-68.55885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.29687 - lat) + Math.Abs(-70.67189 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05983 - lat) + Math.Abs(-72.2346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6135 - lat) + Math.Abs(-71.65702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.9832 - lat) + Math.Abs(-63.88292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.95423 - lat) + Math.Abs(-71.64843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.78709 - lat) + Math.Abs(-69.79294 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.88902 - lat) + Math.Abs(-64.2527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3863 - lat) + Math.Abs(-67.05818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.99352 - lat) + Math.Abs(-65.74247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.43455 - lat) + Math.Abs(-69.1767 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.52987 - lat) + Math.Abs(-71.95922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.54782 - lat) + Math.Abs(-63.15424 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.77278 - lat) + Math.Abs(-70.61541 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.63926 - lat) + Math.Abs(-68.12917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.03333 - lat) + Math.Abs(-61.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01082 - lat) + Math.Abs(-61.90713 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.06088 - lat) + Math.Abs(-69.49765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.19167 - lat) + Math.Abs(-64.69207 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.30589 - lat) + Math.Abs(-67.63212 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.42411 - lat) + Math.Abs(-66.82581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.4751 - lat) + Math.Abs(-70.73493 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.12061 - lat) + Math.Abs(-71.04422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5675 - lat) + Math.Abs(-70.35778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.23777 - lat) + Math.Abs(-67.27008 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0349 - lat) + Math.Abs(-72.05718 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.47801 - lat) + Math.Abs(-71.29693 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.34706 - lat) + Math.Abs(-61.82684 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.96225 - lat) + Math.Abs(-68.29511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.54665 - lat) + Math.Abs(-71.24087 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.28554 - lat) + Math.Abs(-69.16244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.28623 - lat) + Math.Abs(-69.56633 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.02273 - lat) + Math.Abs(-70.67769 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.58057 - lat) + Math.Abs(-60.99778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.45443 - lat) + Math.Abs(-70.55441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16128 - lat) + Math.Abs(-65.70013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.25056 - lat) + Math.Abs(-63.91938 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.45397 - lat) + Math.Abs(-64.18256 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.16245 - lat) + Math.Abs(-66.88248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.4045 - lat) + Math.Abs(-69.67344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.8 - lat) + Math.Abs(-71.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.32611 - lat) + Math.Abs(-72.08742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.62232 - lat) + Math.Abs(-68.91805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.31954 - lat) + Math.Abs(-68.78298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.93991 - lat) + Math.Abs(-65.16517 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.45209 - lat) + Math.Abs(-63.31992 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.20161 - lat) + Math.Abs(-71.3148 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35122 - lat) + Math.Abs(-62.64102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.09535 - lat) + Math.Abs(-69.30798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.35304 - lat) + Math.Abs(-70.57121 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.12923 - lat) + Math.Abs(-63.54086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.81231 - lat) + Math.Abs(-69.53734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.15951 - lat) + Math.Abs(-68.89453 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.92872 - lat) + Math.Abs(-68.27283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.6186 - lat) + Math.Abs(-70.35682 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.24247 - lat) + Math.Abs(-66.85723 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.33754 - lat) + Math.Abs(-66.25282 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.49581 - lat) + Math.Abs(-66.85367 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.08621 - lat) + Math.Abs(-67.91982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48666 - lat) + Math.Abs(-66.73799 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.2831 - lat) + Math.Abs(-66.37591 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.60545 - lat) + Math.Abs(-67.03238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.74602 - lat) + Math.Abs(-72.51889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.5042 - lat) + Math.Abs(-63.41729 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.66516 - lat) + Math.Abs(-63.25387 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.34985 - lat) + Math.Abs(-66.98632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17283 - lat) + Math.Abs(-70.081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.11135 - lat) + Math.Abs(-63.09985 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17335 - lat) + Math.Abs(-63.50048 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.49682 - lat) + Math.Abs(-63.55286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.62857 - lat) + Math.Abs(-70.22864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.48801 - lat) + Math.Abs(-66.87919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.61216 - lat) + Math.Abs(-66.85192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.01171 - lat) + Math.Abs(-71.00458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1755 - lat) + Math.Abs(-70.62072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.30571 - lat) + Math.Abs(-64.35841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.39458 - lat) + Math.Abs(-70.05872 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.78762 - lat) + Math.Abs(-66.90619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.10732 - lat) + Math.Abs(-67.60738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.91426 - lat) + Math.Abs(-70.44745 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.92416 - lat) + Math.Abs(-67.42929 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81755 - lat) + Math.Abs(-63.61331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.63501 - lat) + Math.Abs(-66.16815 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.18634 - lat) + Math.Abs(-67.45935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.1453 - lat) + Math.Abs(-69.61191 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.02658 - lat) + Math.Abs(-69.26203 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.39907 - lat) + Math.Abs(-71.45206 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.27664 - lat) + Math.Abs(-70.76664 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.05052 - lat) + Math.Abs(-69.33257 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.24752 - lat) + Math.Abs(-68.76966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.84659 - lat) + Math.Abs(-69.98032 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.25385 - lat) + Math.Abs(-70.25105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.13191 - lat) + Math.Abs(-65.42236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.96757 - lat) + Math.Abs(-64.1805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.24173 - lat) + Math.Abs(-71.17506 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.36 - lat) + Math.Abs(-69.98302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.84483 - lat) + Math.Abs(-67.51679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.38121 - lat) + Math.Abs(-70.73283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.17383 - lat) + Math.Abs(-68.25892 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.43424 - lat) + Math.Abs(-66.87558 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.76962 - lat) + Math.Abs(-70.11086 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6989 - lat) + Math.Abs(-62.19656 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.0647 - lat) + Math.Abs(-69.35703 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.76171 - lat) + Math.Abs(-70.41199 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.62261 - lat) + Math.Abs(-70.20749 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.13625 - lat) + Math.Abs(-64.68618 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.47855 - lat) + Math.Abs(-66.97458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.25347 - lat) + Math.Abs(-71.82818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.96209 - lat) + Math.Abs(-71.12377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.43949 - lat) + Math.Abs(-68.89496 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.47974 - lat) + Math.Abs(-68.36996 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.22432 - lat) + Math.Abs(-71.13721 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.57998 - lat) + Math.Abs(-64.25548 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.58144 - lat) + Math.Abs(-69.23851 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.70833 - lat) + Math.Abs(-69.65722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.97026 - lat) + Math.Abs(-63.48727 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.45588 - lat) + Math.Abs(-64.82928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.82359 - lat) + Math.Abs(-70.50244 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.86005 - lat) + Math.Abs(-66.38139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.71492 - lat) + Math.Abs(-71.52168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.42489 - lat) + Math.Abs(-63.73077 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.77917 - lat) + Math.Abs(-68.22373 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.55451 - lat) + Math.Abs(-69.19564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.6233 - lat) + Math.Abs(-71.51031 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.17123 - lat) + Math.Abs(-72.15948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.91242 - lat) + Math.Abs(-71.97251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.2054 - lat) + Math.Abs(-67.55948 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06862 - lat) + Math.Abs(-67.81295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.66106 - lat) + Math.Abs(-72.22009 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.85689 - lat) + Math.Abs(-72.181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.39352 - lat) + Math.Abs(-62.45439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.86025 - lat) + Math.Abs(-65.81306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.74569 - lat) + Math.Abs(-63.18323 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.59363 - lat) + Math.Abs(-68.54422 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.56505 - lat) + Math.Abs(-72.44754 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.21523 - lat) + Math.Abs(-72.24888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13316 - lat) + Math.Abs(-71.9839 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.82472 - lat) + Math.Abs(-72.3084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.50734 - lat) + Math.Abs(-71.83201 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.66205 - lat) + Math.Abs(-69.10677 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.10049 - lat) + Math.Abs(-69.04564 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.25934 - lat) + Math.Abs(-70.95248 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.82533 - lat) + Math.Abs(-68.43866 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.46541 - lat) + Math.Abs(-66.82951 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.35782 - lat) + Math.Abs(-66.80252 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.4883 - lat) + Math.Abs(-66.78608 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.24241 - lat) + Math.Abs(-70.73235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.88782 - lat) + Math.Abs(-67.47236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.64636 - lat) + Math.Abs(-67.6072 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.94108 - lat) + Math.Abs(-67.17183 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.8235 - lat) + Math.Abs(-70.25637 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.33432 - lat) + Math.Abs(-68.75512 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.47249 - lat) + Math.Abs(-67.08361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("La Asunción", "17", 11.03333, -63.86278);
case 1: return new CityInfo("Caricuao", "25", 10.43337, -66.98313);
case 2: return new CityInfo("Tocuyito", "07", 10.11347, -68.06783);
case 3: return new CityInfo("El Chaparro", "02", 9.15204, -65.01732);
case 4: return new CityInfo("Anaco", "02", 9.42958, -64.46428);
case 5: return new CityInfo("Santa Cruz de Guacas", "05", 7.44329, -71.30139);
case 6: return new CityInfo("El Real", "05", 8.43525, -69.99633);
case 7: return new CityInfo("Puerto Vivas", "05", 7.50005, -71.84446);
case 8: return new CityInfo("La Mula", "05", 8.57084, -70.37524);
case 9: return new CityInfo("Los Guasimitos", "05", 8.66435, -70.23216);
case 10: return new CityInfo("Alto Barinas", "05", 8.5931, -70.2261);
case 11: return new CityInfo("Zea", "14", 8.37706, -71.78398);
case 12: return new CityInfo("Zaraza", "12", 9.35029, -65.32452);
case 13: return new CityInfo("Yumare", "22", 10.59703, -68.67328);
case 14: return new CityInfo("Yaritagua", "22", 10.08081, -69.1242);
case 15: return new CityInfo("Yaracal", "11", 10.96985, -68.54648);
case 16: return new CityInfo("Yaguaraparo", "19", 10.56839, -62.82628);
case 17: return new CityInfo("Villa de Cura", "04", 10.03863, -67.48938);
case 18: return new CityInfo("Villa Bruzual", "18", 9.33186, -69.11968);
case 19: return new CityInfo("Las Casitas del Vegon de Nutrias", "05", 8.23704, -69.4183);
case 20: return new CityInfo("Valle de La Pascua", "12", 9.21554, -66.00734);
case 21: return new CityInfo("Valle de Guanape", "02", 9.90999, -65.67405);
case 22: return new CityInfo("Valera", "21", 9.31778, -70.60361);
case 23: return new CityInfo("Valencia", "07", 10.16202, -68.00765);
case 24: return new CityInfo("Urumaco", "11", 11.2007, -70.25597);
case 25: return new CityInfo("Ureña", "20", 7.91857, -72.44708);
case 26: return new CityInfo("Uracoa", "16", 8.99432, -62.35202);
case 27: return new CityInfo("Urachiche", "22", 10.15847, -69.00782);
case 28: return new CityInfo("Upata", "06", 8.0162, -62.40561);
case 29: return new CityInfo("Umuquena", "20", 8.26648, -72.06432);
case 30: return new CityInfo("Turmero", "04", 10.22856, -67.47421);
case 31: return new CityInfo("Tunapuy", "19", 10.5748, -63.10751);
case 32: return new CityInfo("Tumeremo", "06", 7.29861, -61.50497);
case 33: return new CityInfo("Tucupita", "09", 9.05806, -62.05);
case 34: return new CityInfo("Tucupido", "12", 9.27304, -65.77153);
case 35: return new CityInfo("Tucaní", "14", 8.97003, -71.27277);
case 36: return new CityInfo("Tucacas", "11", 10.79006, -68.32564);
case 37: return new CityInfo("Trujillo", "21", 9.36583, -70.43694);
case 38: return new CityInfo("Tovar", "14", 8.33015, -71.75277);
case 39: return new CityInfo("Torunos", "05", 8.50015, -70.08056);
case 40: return new CityInfo("Torondoy", "14", 9.03457, -71.01412);
case 41: return new CityInfo("Tocópero", "11", 11.49946, -69.259);
case 42: return new CityInfo("Tinaquillo", "08", 9.91861, -68.30472);
case 43: return new CityInfo("Tinaco", "08", 9.69894, -68.43273);
case 44: return new CityInfo("Timotes", "14", 8.98224, -70.73926);
case 45: return new CityInfo("Tía Juana", "23", 10.25927, -71.36343);
case 46: return new CityInfo("Temblador", "16", 9.00525, -62.64493);
case 47: return new CityInfo("Táriba", "20", 7.8188, -72.22427);
case 48: return new CityInfo("Tabay", "14", 8.6317, -71.07833);
case 49: return new CityInfo("Soledad", "02", 8.16206, -63.5654);
case 50: return new CityInfo("Socopó", "05", 8.23062, -70.82198);
case 51: return new CityInfo("Siquisique", "13", 10.57112, -69.70172);
case 52: return new CityInfo("Sinamaica", "23", 11.08656, -71.85595);
case 53: return new CityInfo("Seboruco", "20", 8.14514, -72.07332);
case 54: return new CityInfo("Sarare", "13", 9.78129, -69.1633);
case 55: return new CityInfo("Santo Domingo", "14", 8.86052, -70.6948);
case 56: return new CityInfo("San Timoteo", "23", 9.7901, -71.07084);
case 57: return new CityInfo("Santa Teresa del Tuy", "15", 10.23291, -66.66474);
case 58: return new CityInfo("Santa Rosa", "05", 8.44033, -69.70105);
case 59: return new CityInfo("Santa Rita", "23", 10.53642, -71.51104);
case 60: return new CityInfo("Santa María de Ipire", "12", 8.81556, -65.3225);
case 61: return new CityInfo("Santa María de Caparo", "14", 7.71412, -71.46466);
case 62: return new CityInfo("Santa Lucía", "15", 10.30494, -66.65998);
case 63: return new CityInfo("Santa Lucía", "05", 8.10155, -69.77752);
case 64: return new CityInfo("Santa Isabel", "21", 9.63163, -70.80837);
case 65: return new CityInfo("Santa Inés", "05", 8.26241, -69.89795);
case 66: return new CityInfo("Santa Elena de Uairén", "06", 4.60226, -61.11025);
case 67: return new CityInfo("Santa Elena de Arenales", "14", 8.82062, -71.46572);
case 68: return new CityInfo("Santa Cruz de Mora", "14", 8.39925, -71.64082);
case 69: return new CityInfo("Santa Cruz de Bucaral", "11", 10.81919, -69.27679);
case 70: return new CityInfo("Santa Cruz", "04", 10.18, -67.51184);
case 71: return new CityInfo("Santa Catalina", "05", 7.92408, -68.91745);
case 72: return new CityInfo("Santa Bárbara", "16", 9.60745, -63.60938);
case 73: return new CityInfo("Santa Bárbara", "05", 7.81348, -71.17788);
case 74: return new CityInfo("Santa Apolonia", "21", 9.47135, -71.01213);
case 75: return new CityInfo("Santa Ana", "17", 11.06828, -63.92239);
case 76: return new CityInfo("Santa Ana", "02", 9.3056, -64.65478);
case 77: return new CityInfo("Santa Ana", "20", 8.11697, -72.02174);
case 78: return new CityInfo("Santa Ana", "20", 7.6422, -72.27694);
case 79: return new CityInfo("San Simón", "20", 8.35018, -71.85114);
case 80: return new CityInfo("San Silvestre", "05", 8.27585, -70.11027);
case 81: return new CityInfo("San Rafael de Onoto", "18", 9.67813, -68.97278);
case 82: return new CityInfo("Carvajal", "21", 9.3067, -70.59042);
case 83: return new CityInfo("San Rafael de Canaguá", "05", 8.02667, -70.00861);
case 84: return new CityInfo("San Pedro de Coche", "17", 10.78131, -63.99675);
case 85: return new CityInfo("San Pablo", "22", 10.24929, -68.84427);
case 86: return new CityInfo("San Mateo", "04", 10.21302, -67.42365);
case 87: return new CityInfo("San Mateo", "02", 9.74004, -64.54937);
case 88: return new CityInfo("San Luis", "11", 11.12034, -69.68397);
case 89: return new CityInfo("San Juan de Manapiare", "01", 5.32665, -66.05402);
case 90: return new CityInfo("San Juan de los Morros", "12", 9.91152, -67.35381);
case 91: return new CityInfo("San Juan de los Cayos", "11", 11.17203, -68.4128);
case 92: return new CityInfo("Colón", "20", 8.03125, -72.26053);
case 93: return new CityInfo("San Juan Bautista", "17", 11.01422, -63.94383);
case 94: return new CityInfo("San José de Barlovento", "15", 10.30125, -65.99053);
case 95: return new CityInfo("San José de Guanipa", "02", 8.88724, -64.16512);
case 96: return new CityInfo("San José de Aerocuar", "19", 10.59973, -63.32852);
case 97: return new CityInfo("San Joaquín", "07", 10.26061, -67.79348);
case 98: return new CityInfo("San Francisco de Yare", "15", 10.17793, -66.74649);
case 99: return new CityInfo("San Francisco", "23", 10.55363, -71.70364);
case 100: return new CityInfo("San Fernando de Atabapo", "01", 4.04564, -67.69934);
case 101: return new CityInfo("San Felipe", "22", 10.33991, -68.74247);
case 102: return new CityInfo("San Diego", "07", 10.26057, -67.95363);
case 103: return new CityInfo("San Cristóbal", "20", 7.76694, -72.225);
case 104: return new CityInfo("San Casimiro", "04", 10.00169, -67.01464);
case 105: return new CityInfo("San Carlos de Río Negro", "01", 1.92027, -67.06089);
case 106: return new CityInfo("San Carlos del Zulia", "23", 9.00098, -71.92683);
case 107: return new CityInfo("San Carlos", "08", 9.66124, -68.58268);
case 108: return new CityInfo("Sanare", "13", 9.75209, -69.6524);
case 109: return new CityInfo("San Antonio del Táchira", "20", 7.81454, -72.4431);
case 110: return new CityInfo("San Antonio de Los Altos", "15", 10.38853, -66.95179);
case 111: return new CityInfo("San Antonio del Golfo", "19", 10.44198, -63.78874);
case 112: return new CityInfo("San Antonio", "16", 10.11914, -63.72535);
case 113: return new CityInfo("San Antonio", "05", 7.96378, -68.43384);
case 114: return new CityInfo("Sabaneta", "05", 8.75234, -69.93351);
case 115: return new CityInfo("Sabana Grande", "21", 9.4018, -70.79812);
case 116: return new CityInfo("Sabana de Parra", "22", 10.12111, -69.03639);
case 117: return new CityInfo("Sabana de Mendoza", "21", 9.43494, -70.77495);
case 118: return new CityInfo("Rubio", "20", 7.70131, -72.35569);
case 119: return new CityInfo("La Villa del Rosario", "23", 10.3258, -72.31343);
case 120: return new CityInfo("Río Chico", "15", 10.31899, -65.97751);
case 121: return new CityInfo("Río Caribe", "19", 10.6977, -63.10871);
case 122: return new CityInfo("Quiriquire", "16", 9.9795, -63.21991);
case 123: return new CityInfo("Quíbor", "13", 9.92866, -69.6201);
case 124: return new CityInfo("Queniquea", "20", 7.91659, -72.0138);
case 125: return new CityInfo("Quebrada Seca", "05", 8.70015, -70.31941);
case 126: return new CityInfo("Punto Fijo", "11", 11.69152, -70.19918);
case 127: return new CityInfo("Punta de Piedras", "17", 10.90123, -64.0969);
case 128: return new CityInfo("Punta de Piedra", "05", 7.61759, -71.49164);
case 129: return new CityInfo("Punta de Mata", "16", 9.69131, -63.60921);
case 130: return new CityInfo("Punta Cardón", "11", 11.65806, -70.215);
case 131: return new CityInfo("Puerto Píritu", "02", 10.05896, -65.03698);
case 132: return new CityInfo("Puerto La Cruz", "02", 10.21382, -64.6328);
case 133: return new CityInfo("Puerto de Nutrias", "05", 8.07281, -69.30246);
case 134: return new CityInfo("Puerto Cumarebo", "11", 11.48614, -69.35319);
case 135: return new CityInfo("Puerto Cabello", "07", 10.47306, -68.0125);
case 136: return new CityInfo("Puerto Ayacucho", "01", 5.66049, -67.58343);
case 137: return new CityInfo("Pueblo Nuevo", "11", 11.94788, -69.92306);
case 138: return new CityInfo("Pueblo Nuevo El Chivo", "23", 8.96249, -71.60754);
case 139: return new CityInfo("Pueblo Llano", "14", 8.9152, -70.65919);
case 140: return new CityInfo("Pregonero", "20", 8.01909, -71.76595);
case 141: return new CityInfo("Porlamar", "17", 10.95771, -63.86971);
case 142: return new CityInfo("Píritu", "11", 11.36648, -69.13807);
case 143: return new CityInfo("Píritu", "02", 10.0395, -65.03037);
case 144: return new CityInfo("Píritu", "18", 9.37083, -69.21028);
case 145: return new CityInfo("Petare", "15", 10.47679, -66.80786);
case 146: return new CityInfo("Pedregal", "11", 11.02012, -70.11997);
case 147: return new CityInfo("Pedraza La Vieja", "05", 7.9168, -71.05934);
case 148: return new CityInfo("Pedernales", "09", 9.971, -62.252);
case 149: return new CityInfo("Pariaguán", "02", 8.84357, -64.71053);
case 150: return new CityInfo("Paraíso de Chabasquén", "18", 9.43326, -69.94728);
case 151: return new CityInfo("La Plaza Paraguachi", "17", 11.10783, -63.85537);
case 152: return new CityInfo("Papelón", "18", 8.94109, -69.46021);
case 153: return new CityInfo("Pampatar", "17", 11.00122, -63.79297);
case 154: return new CityInfo("Pampanito", "21", 9.41037, -70.50116);
case 155: return new CityInfo("Pampán", "21", 9.44519, -70.47556);
case 156: return new CityInfo("Palo Negro", "04", 10.17389, -67.54194);
case 157: return new CityInfo("Palmira", "20", 7.8373, -72.22802);
case 158: return new CityInfo("Palmasola", "12", 9.23333, -66.71667);
case 159: return new CityInfo("Ospino", "18", 9.29572, -69.45434);
case 160: return new CityInfo("Ortiz", "12", 9.62168, -67.29047);
case 161: return new CityInfo("Onoto", "02", 9.59714, -65.1935);
case 162: return new CityInfo("Ocumare del Tuy", "15", 10.1182, -66.77513);
case 163: return new CityInfo("Ocumare de la Costa", "04", 10.46127, -67.76872);
case 164: return new CityInfo("Obispos", "05", 8.60701, -70.10489);
case 165: return new CityInfo("Nueva Bolivia", "14", 9.14007, -71.09143);
case 166: return new CityInfo("Nirgua", "22", 10.15039, -68.56478);
case 167: return new CityInfo("Naiguatá", "26", 10.62026, -66.73833);
case 168: return new CityInfo("Naguanagua", "07", 10.25604, -68.01649);
case 169: return new CityInfo("Mucumpiz", "14", 8.41667, -71.13333);
case 170: return new CityInfo("Mucuchíes", "14", 8.74921, -70.91978);
case 171: return new CityInfo("Motatán", "21", 9.39182, -70.59061);
case 172: return new CityInfo("Morón", "07", 10.48715, -68.20078);
case 173: return new CityInfo("Monte Carmelo", "21", 9.18821, -70.81229);
case 174: return new CityInfo("Montalbán", "07", 10.21313, -68.32669);
case 175: return new CityInfo("Mirimire", "11", 11.1602, -68.72604);
case 176: return new CityInfo("Miranda", "07", 10.15077, -68.39325);
case 177: return new CityInfo("Michelena", "20", 7.95655, -72.24299);
case 178: return new CityInfo("Mérida", "14", 8.58972, -71.15611);
case 179: return new CityInfo("Mene de Mauroa", "11", 10.68091, -71.03609);
case 180: return new CityInfo("Masparrito", "05", 9.00194, -70.30139);
case 181: return new CityInfo("Maroa", "01", 2.7188, -67.56046);
case 182: return new CityInfo("Maripa", "06", 7.41584, -65.19034);
case 183: return new CityInfo("Marigüitar", "19", 10.44789, -63.90161);
case 184: return new CityInfo("Mariara", "07", 10.29532, -67.7177);
case 185: return new CityInfo("Maracay", "04", 10.23535, -67.59113);
case 186: return new CityInfo("Maracaibo", "23", 10.66663, -71.61245);
case 187: return new CityInfo("Maporal", "05", 7.645, -70.41985);
case 188: return new CityInfo("Mapire", "02", 7.74085, -64.71047);
case 189: return new CityInfo("Mamporal", "15", 10.36556, -66.13391);
case 190: return new CityInfo("Maiquetía", "26", 10.5945, -66.95624);
case 191: return new CityInfo("Macuto", "26", 10.60508, -66.89745);
case 192: return new CityInfo("Machiques", "23", 10.06077, -72.55212);
case 193: return new CityInfo("Los Teques", "15", 10.34447, -67.04325);
case 194: return new CityInfo("Los Rastrojos", "13", 10.02588, -69.24166);
case 195: return new CityInfo("Los Guayos", "07", 10.18932, -67.93828);
case 196: return new CityInfo("Los Dos Caminos", "15", 10.49389, -66.82863);
case 197: return new CityInfo("Lobatera", "20", 7.92978, -72.24731);
case 198: return new CityInfo("Libertad", "08", 9.35654, -68.69221);
case 199: return new CityInfo("Libertad", "05", 8.32709, -69.63093);
case 200: return new CityInfo("Canaguá", "14", 8.12489, -71.46041);
case 201: return new CityInfo("Capacho Viejo", "20", 7.82893, -72.31942);
case 202: return new CityInfo("La Yuca", "05", 8.73109, -70.18072);
case 203: return new CityInfo("La Victoria", "04", 10.22677, -67.33122);
case 204: return new CityInfo("La Vela de Coro", "11", 11.46077, -69.5657);
case 205: return new CityInfo("Veguitas", "05", 8.82391, -69.99581);
case 206: return new CityInfo("La Unión", "05", 8.21573, -67.76653);
case 207: return new CityInfo("Las Vegas", "08", 9.53724, -68.63022);
case 208: return new CityInfo("Las Tejerías", "04", 10.25416, -67.17333);
case 209: return new CityInfo("Las Mercedes", "12", 9.11037, -66.39607);
case 210: return new CityInfo("La Sabana", "26", 10.61867, -66.38194);
case 211: return new CityInfo("La Quebrada", "21", 9.15522, -70.57702);
case 212: return new CityInfo("La Plata", "23", 10.32025, -71.2721);
case 213: return new CityInfo("La Luz", "05", 8.39419, -69.82358);
case 214: return new CityInfo("Lagunillas", "23", 10.13008, -71.25946);
case 215: return new CityInfo("Lagunillas", "14", 8.50457, -71.3894);
case 216: return new CityInfo("La Guaira", "26", 10.60156, -66.93293);
case 217: return new CityInfo("La Esmeralda", "01", 3.17453, -65.54517);
case 218: return new CityInfo("La Cruz de Taratara", "11", 11.06302, -69.71287);
case 219: return new CityInfo("La Concepción", "23", 10.61919, -71.83814);
case 220: return new CityInfo("Concepción", "23", 10.4119, -71.68919);
case 221: return new CityInfo("Chameta", "05", 8.10023, -70.90671);
case 222: return new CityInfo("Caramuca", "05", 8.59708, -70.32056);
case 223: return new CityInfo("La Azulita", "14", 8.71364, -71.44421);
case 224: return new CityInfo("Juan Griego", "17", 11.08172, -63.96549);
case 225: return new CityInfo("Jacura", "11", 11.07446, -68.85583);
case 226: return new CityInfo("Irapa", "19", 10.57006, -62.58204);
case 227: return new CityInfo("Higuerote", "15", 10.48287, -66.10096);
case 228: return new CityInfo("Güiria", "19", 10.57721, -62.29841);
case 229: return new CityInfo("Güigüe", "07", 10.08344, -67.77799);
case 230: return new CityInfo("Guayabal", "12", 8.00077, -67.39732);
case 231: return new CityInfo("Guatire", "15", 10.474, -66.54241);
case 232: return new CityInfo("Guasipati", "06", 7.47702, -61.89666);
case 233: return new CityInfo("Guarenas", "15", 10.47027, -66.61934);
case 234: return new CityInfo("Guaraque", "14", 8.15405, -71.73562);
case 235: return new CityInfo("Guanta", "02", 10.23453, -64.59708);
case 236: return new CityInfo("Guanarito", "18", 8.69625, -69.20832);
case 237: return new CityInfo("Guanare", "18", 9.04183, -69.74206);
case 238: return new CityInfo("Guama", "22", 10.26638, -68.81986);
case 239: return new CityInfo("Guadarrama", "05", 8.53508, -68.04923);
case 240: return new CityInfo("Guacara", "07", 10.22609, -67.877);
case 241: return new CityInfo("Farriar", "22", 10.47016, -68.55885);
case 242: return new CityInfo("Escuque", "21", 9.29687, -70.67189);
case 243: return new CityInfo("Encontrados", "23", 9.05983, -72.2346);
case 244: return new CityInfo("El Vigía", "14", 8.6135, -71.65702);
case 245: return new CityInfo("El Valle del Espíritu Santo", "17", 10.9832, -63.88292);
case 246: return new CityInfo("El Toro", "23", 10.95423, -71.64843);
case 247: return new CityInfo("El Tocuyo", "13", 9.78709, -69.79294);
case 248: return new CityInfo("El Tigre", "02", 8.88902, -64.2527);
case 249: return new CityInfo("El Sombrero", "12", 9.3863, -67.05818);
case 250: return new CityInfo("El Socorro", "12", 8.99352, -65.74247);
case 251: return new CityInfo("El Regalo", "05", 8.43455, -69.1767);
case 252: return new CityInfo("San Rafael del Piñal", "20", 7.52987, -71.95922);
case 253: return new CityInfo("El Pilar", "19", 10.54782, -63.15424);
case 254: return new CityInfo("El Paradero", "21", 9.77278, -70.61541);
case 255: return new CityInfo("El Pao", "08", 9.63926, -68.12917);
case 256: return new CityInfo("El Palmer", "06", 8.03333, -61.88333);
case 257: return new CityInfo("El Palmar", "06", 8.01082, -61.90713);
case 258: return new CityInfo("Elorza", "03", 7.06088, -69.49765);
case 259: return new CityInfo("Lecherías", "02", 10.19167, -64.69207);
case 260: return new CityInfo("El Limón", "04", 10.30589, -67.63212);
case 261: return new CityInfo("El Hatillo", "15", 10.42411, -66.82581);
case 262: return new CityInfo("El Dividive", "21", 9.4751, -70.73493);
case 263: return new CityInfo("El Corozo", "23", 10.12061, -71.04422);
case 264: return new CityInfo("El Corozo", "05", 8.5675, -70.35778);
case 265: return new CityInfo("El Consejo", "04", 10.23777, -67.27008);
case 266: return new CityInfo("El Cobre", "20", 8.0349, -72.05718);
case 267: return new CityInfo("El Cantón", "05", 7.47801, -71.29693);
case 268: return new CityInfo("El Callao", "06", 7.34706, -61.82684);
case 269: return new CityInfo("El Baúl", "08", 8.96225, -68.29511);
case 270: return new CityInfo("Ejido", "14", 8.54665, -71.24087);
case 271: return new CityInfo("Duaca", "13", 10.28554, -69.16244);
case 272: return new CityInfo("Dolores", "05", 8.28623, -69.56633);
case 273: return new CityInfo("Dabajuro", "11", 11.02273, -70.67769);
case 274: return new CityInfo("Curiapo", "09", 8.58057, -60.99778);
case 275: return new CityInfo("Curbatí", "05", 8.45443, -70.55441);
case 276: return new CityInfo("Cúpira", "15", 10.16128, -65.70013);
case 277: return new CityInfo("Cumanacoa", "19", 10.25056, -63.91938);
case 278: return new CityInfo("Cumaná", "19", 10.45397, -64.18256);
case 279: return new CityInfo("Cúa", "15", 10.16245, -66.88248);
case 280: return new CityInfo("Coro", "11", 11.4045, -69.67344);
case 281: return new CityInfo("Concepción", "23", 10.8, -71.76667);
case 282: return new CityInfo("Coloncito", "20", 8.32611, -72.08742);
case 283: return new CityInfo("Cojedes", "08", 9.62232, -68.91805);
case 284: return new CityInfo("Cocorote", "22", 10.31954, -68.78298);
case 285: return new CityInfo("Clarines", "02", 9.93991, -65.16517);
case 286: return new CityInfo("Ciudad Piar", "06", 7.45209, -63.31992);
case 287: return new CityInfo("Ciudad Ojeda", "23", 10.20161, -71.3148);
case 288: return new CityInfo("Ciudad Guayana", "06", 8.35122, -62.64102);
case 289: return new CityInfo("Ciudad De Nutrias", "05", 8.09535, -69.30798);
case 290: return new CityInfo("Ciudad Bolivia", "05", 8.35304, -70.57121);
case 291: return new CityInfo("Ciudad Bolívar", "06", 8.12923, -63.54086);
case 292: return new CityInfo("Churuguara", "11", 10.81231, -69.53734);
case 293: return new CityInfo("Chivacoa", "22", 10.15951, -68.89453);
case 294: return new CityInfo("Chichiriviche", "11", 10.92872, -68.27283);
case 295: return new CityInfo("Chejendé", "21", 9.6186, -70.35682);
case 296: return new CityInfo("Charallave", "15", 10.24247, -66.85723);
case 297: return new CityInfo("Chaguaramas", "12", 9.33754, -66.25282);
case 298: return new CityInfo("Chacao", "15", 10.49581, -66.85367);
case 299: return new CityInfo("Tacarigua", "07", 10.08621, -67.91982);
case 300: return new CityInfo("Caucagüito", "15", 10.48666, -66.73799);
case 301: return new CityInfo("Caucagua", "15", 10.2831, -66.37591);
case 302: return new CityInfo("Catia La Mar", "26", 10.60545, -67.03238);
case 303: return new CityInfo("Casigua El Cubo", "23", 8.74602, -72.51889);
case 304: return new CityInfo("Casanay", "19", 10.5042, -63.41729);
case 305: return new CityInfo("Carúpano", "19", 10.66516, -63.25387);
case 306: return new CityInfo("Carrizal", "15", 10.34985, -66.98632);
case 307: return new CityInfo("Carora", "13", 10.17283, -70.081);
case 308: return new CityInfo("Caripito", "16", 10.11135, -63.09985);
case 309: return new CityInfo("Caripe", "16", 10.17335, -63.50048);
case 310: return new CityInfo("Cariaco", "19", 10.49682, -63.55286);
case 311: return new CityInfo("Carache", "21", 9.62857, -70.22864);
case 312: return new CityInfo("Caracas", "25", 10.48801, -66.87919);
case 313: return new CityInfo("Caraballeda", "26", 10.61216, -66.85192);
case 314: return new CityInfo("Capitanejo", "05", 8.01171, -71.00458);
case 315: return new CityInfo("Canape Capatárida", "11", 11.1755, -70.62072);
case 316: return new CityInfo("Cantaura", "02", 9.30571, -64.35841);
case 317: return new CityInfo("Campo Elías", "21", 9.39458, -70.05872);
case 318: return new CityInfo("Camatagua", "04", 9.78762, -66.90619);
case 319: return new CityInfo("Camaguán", "12", 8.10732, -67.60738);
case 320: return new CityInfo("Calderas", "05", 8.91426, -70.44745);
case 321: return new CityInfo("Calabozo", "12", 8.92416, -67.42929);
case 322: return new CityInfo("Caicara", "16", 9.81755, -63.61331);
case 323: return new CityInfo("Caicara del Orinoco", "06", 7.63501, -66.16815);
case 324: return new CityInfo("Cagua", "04", 10.18634, -67.45935);
case 325: return new CityInfo("Cabure", "11", 11.1453, -69.61191);
case 326: return new CityInfo("Cabudare", "13", 10.02658, -69.26203);
case 327: return new CityInfo("Cabimas", "23", 10.39907, -71.45206);
case 328: return new CityInfo("Bum Bum", "05", 8.27664, -70.76664);
case 329: return new CityInfo("Bruzual", "03", 8.05052, -69.33257);
case 330: return new CityInfo("Boraure", "22", 10.24752, -68.76966);
case 331: return new CityInfo("Boconoito", "18", 8.84659, -69.98032);
case 332: return new CityInfo("Boconó", "21", 9.25385, -70.25105);
case 333: return new CityInfo("Boca de Uchire", "02", 10.13191, -65.42236);
case 334: return new CityInfo("Boca de Río", "17", 10.96757, -64.1805);
case 335: return new CityInfo("Bobures", "23", 9.24173, -71.17506);
case 336: return new CityInfo("Biscucuy", "18", 9.36, -69.98302);
case 337: return new CityInfo("Biruaca", "03", 7.84483, -67.51679);
case 338: return new CityInfo("Betijoque", "21", 9.38121, -70.73283);
case 339: return new CityInfo("Bejuma", "07", 10.17383, -68.25892);
case 340: return new CityInfo("Baruta", "15", 10.43424, -66.87558);
case 341: return new CityInfo("Barrancas", "05", 8.76962, -70.11086);
case 342: return new CityInfo("Barrancas", "16", 8.6989, -62.19656);
case 343: return new CityInfo("Barquisimeto", "13", 10.0647, -69.35703);
case 344: return new CityInfo("Barinitas", "05", 8.76171, -70.41199);
case 345: return new CityInfo("Barinas", "05", 8.62261, -70.20749);
case 346: return new CityInfo("Barcelona", "02", 10.13625, -64.68618);
case 347: return new CityInfo("Barbacoas", "04", 9.47855, -66.97458);
case 348: return new CityInfo("Bailadores", "14", 8.25347, -71.82818);
case 349: return new CityInfo("Bachaquero", "23", 9.96209, -71.12377);
case 350: return new CityInfo("Aroa", "22", 10.43949, -68.89496);
case 351: return new CityInfo("Arismendi", "05", 8.47974, -68.36996);
case 352: return new CityInfo("Aricagua", "14", 8.22432, -71.13721);
case 353: return new CityInfo("Araya", "19", 10.57998, -64.25548);
case 354: return new CityInfo("Araure", "18", 9.58144, -69.23851);
case 355: return new CityInfo("Arauquita", "05", 8.70833, -69.65722);
case 356: return new CityInfo("Aragua", "16", 9.97026, -63.48727);
case 357: return new CityInfo("Aragua de Barcelona", "02", 9.45588, -64.82928);
case 358: return new CityInfo("Altamira", "05", 8.82359, -70.50244);
case 359: return new CityInfo("Altagracia de Orituco", "12", 9.86005, -66.38139);
case 360: return new CityInfo("Los Puertos de Altagracia", "23", 10.71492, -71.52168);
case 361: return new CityInfo("Aguasay", "16", 9.42489, -63.73077);
case 362: return new CityInfo("Achaguas", "03", 7.77917, -68.22373);
case 363: return new CityInfo("Acarigua", "18", 9.55451, -69.19564);
case 364: return new CityInfo("Abejales", "20", 7.6233, -71.51031);
case 365: return new CityInfo("Las Mesas", "20", 8.17123, -72.15948);
case 366: return new CityInfo("San José de Bolívar", "20", 7.91242, -71.97251);
case 367: return new CityInfo("Santa Rita", "04", 10.2054, -67.55948);
case 368: return new CityInfo("Isla Ratón", "01", 5.06862, -67.81295);
case 369: return new CityInfo("San Josecito", "20", 7.66106, -72.22009);
case 370: return new CityInfo("Cordero", "20", 7.85689, -72.181);
case 371: return new CityInfo("Sierra Imataca", "09", 8.39352, -62.45439);
case 372: return new CityInfo("San José de Guaribe", "12", 9.86025, -65.81306);
case 373: return new CityInfo("Maturín", "16", 9.74569, -63.18323);
case 374: return new CityInfo("Palmasola", "11", 10.59363, -68.54422);
case 375: return new CityInfo("Delicias", "20", 7.56505, -72.44754);
case 376: return new CityInfo("La Fría", "20", 8.21523, -72.24888);
case 377: return new CityInfo("La Grita", "20", 8.13316, -71.9839);
case 378: return new CityInfo("Capacho Nuevo", "20", 7.82472, -72.3084);
case 379: return new CityInfo("La Tendida", "20", 8.50734, -71.83201);
case 380: return new CityInfo("Agua Blanca", "18", 9.66205, -69.10677);
case 381: return new CityInfo("El Playón", "18", 9.10049, -69.04564);
case 382: return new CityInfo("Arapuey", "14", 9.25934, -70.95248);
case 383: return new CityInfo("Macapo", "08", 9.82533, -68.43866);
case 384: return new CityInfo("El Cafetal", "15", 10.46541, -66.82951);
case 385: return new CityInfo("Caucaguita", "15", 10.35782, -66.80252);
case 386: return new CityInfo("La Dolorita", "15", 10.4883, -66.78608);
case 387: return new CityInfo("Guasdualito", "03", 7.24241, -70.73235);
case 388: return new CityInfo("San Fernando de Apure", "03", 7.88782, -67.47236);
case 389: return new CityInfo("San Juan de Payara", "03", 7.64636, -67.6072);
case 390: return new CityInfo("San Sebastián", "04", 9.94108, -67.17183);
case 391: return new CityInfo("Santa Cruz de los Taques", "11", 11.8235, -70.25637);
case 392: return new CityInfo("Independencia", "22", 10.33432, -68.75512);
default: return new CityInfo("El Junko", "26", 10.47249, -67.08361);

                                    }                                        
                                }
                            
                        }
                    }
                