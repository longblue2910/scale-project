/// <summary>
/// Cac van  de Convert Font
/// </summary>
/// <remarks></remarks>
using C1.Win.C1Command;
using C1.Win.C1Input;
using C1.Win.C1List;
using C1.Win.C1TrueDBGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Electric_Scale.func
{
	internal static class cls_ConvertFont
	{
		/// <summary>
		/// Convert chuoi tu VietwareF (MS Sans Serif, DG Sans Serif) sang Unicode
		/// </summary>
		/// <param name="sText"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static string ConvertVietwareFToUnicode(string sText)
		{
			string sRet = sText;

			sRet = sRet.Replace(System.Convert.ToString((char)(249)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(252)), "ý");
			sRet = sRet.Replace(System.Convert.ToString((char)(255)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(250)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(251)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(238)), "ù");
			sRet = sRet.Replace(System.Convert.ToString((char)(242)), "ú");
			sRet = sRet.Replace(System.Convert.ToString((char)(243)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(239)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(241)), "u");

			sRet = sRet.Replace(System.Convert.ToString((char)(167)), "u");
			sRet = sRet.Replace(System.Convert.ToString((char)(244)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(247)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(248)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(245)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(246)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(223)), "ò");
			sRet = sRet.Replace(System.Convert.ToString((char)(226)), "ó");
			sRet = sRet.Replace(System.Convert.ToString((char)(227)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(224)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(225)), "õ");

			sRet = sRet.Replace(System.Convert.ToString((char)(228)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(231)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(232)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(229)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(230)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(233)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(236)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(237)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(234)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(235)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(216)), "ì");
			sRet = sRet.Replace(System.Convert.ToString((char)(219)), "í");
			sRet = sRet.Replace(System.Convert.ToString((char)(220)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(217)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(218)), "i");

			sRet = sRet.Replace(System.Convert.ToString((char)(164)), "ô");
			sRet = sRet.Replace(System.Convert.ToString((char)(165)), "o");

			sRet = sRet.Replace(System.Convert.ToString((char)(170)), "à");
			sRet = sRet.Replace(System.Convert.ToString((char)(192)), "á");
			sRet = sRet.Replace(System.Convert.ToString((char)(193)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(182)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(186)), "ã");

			sRet = sRet.Replace(System.Convert.ToString((char)(376)), "a");
			sRet = sRet.Replace(System.Convert.ToString((char)(194)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(197)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(198)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(195)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(196)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(161)), "â");
			sRet = sRet.Replace(System.Convert.ToString((char)(199)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(202)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(203)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(200)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(201)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(204)), "è");
			sRet = sRet.Replace(System.Convert.ToString((char)(207)), "é");
			sRet = sRet.Replace(System.Convert.ToString((char)(209)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(205)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(206)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(163)), "ê");
			sRet = sRet.Replace(System.Convert.ToString((char)(210)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(213)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(214)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(211)), "?");
			sRet = sRet.Replace(System.Convert.ToString((char)(212)), "?");

			sRet = sRet.Replace(System.Convert.ToString((char)(162)), "d");

			sRet = sRet.Replace(System.Convert.ToString((char)(8211)), "A");
			sRet = sRet.Replace(System.Convert.ToString((char)(8212)), "Â");
			sRet = sRet.Replace(System.Convert.ToString((char)(732)), "Ð");
			sRet = sRet.Replace(System.Convert.ToString((char)(8482)), "Ê");
			sRet = sRet.Replace(System.Convert.ToString((char)(353)), "Ô");
			sRet = sRet.Replace(System.Convert.ToString((char)(8250)), "O");
			sRet = sRet.Replace(System.Convert.ToString((char)(339)), "U");

			return sRet;
		}

		/// <summary>
		/// Convert chuoi tu VNI sang Unicode
		/// </summary>
		/// <param name="szInput"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static string ConvertVniToUnicode(string szInput)
		{
			char sChar = '\0';
				char sNextChar = '\0';
			string sInput = null;
				string sOutput = null;

			if (System.Convert.IsDBNull(szInput))
			{
				return "";
			}

			if (szInput == "")
			{
				return "";
			}

			sInput = szInput.Trim();

			if (sInput.Length == 0)
			{
				return "";
			}

			sOutput = "";

			//check the first char
			do
			{
				sChar = Convert.ToChar(sInput.Substring(0, 1));

				if (CheckVNIVowel(sChar))
				{
					if (sInput.Length > 1)
					{
						sNextChar = Convert.ToChar(sInput.Substring(1, 1));
						int code = System.Convert.ToInt32(sNextChar);
						if (CheckVNIAccent(sNextChar))
						{
							sOutput += CDoubleVNI(sChar, sNextChar);

							if (sInput.Length > 2)
							{
								sInput = sInput.Substring(2);
							}
							else
							{
								break;
							}

						}
						else
						{
							sOutput += CSingleVNI(sChar);
							sInput = sInput.Substring(1);
						}
					}
					else
					{
						sOutput += CSingleVNI(sChar);
						break;
					}
				}
				else
				{
					//Response.Write "<p>" & sChar & ": not a vowel"
					sOutput += CSingleVNI(sChar);
					if (sInput.Length > 1)
					{
						sInput = sInput.Substring(1);
					}
					else
					{
						break;
					}
				}
			} while (true);

			return sOutput;
		}

		public static string CSingleVNI(char szInput)
		{
			//input: single character (vowel and consonant)
			//output Unicode character
			string sResult = null;
			//Dim sInput As String
			//sInput = szInput

			switch (System.Convert.ToInt32(szInput))
			{
				case 209: //D with dash,
					sResult = "&#272;";
					sResult = "Ð";

					break;
				case 241: //d with dash
					sResult = "&#273;";
					sResult = "d";

					break;
				case 212: //O)
					sResult = "&#416;";
					sResult = "O";

					break;
				case 244: //o)
					sResult = "&#417;";
					sResult = "o";

					break;
				case 214: //U)
					sResult = "&#431;";
					sResult = "U";

					break;
				case 246: //u)
					sResult = "&#432;";
					sResult = "u";

					break;
				case 204: //I`
					sResult = "&Igrave;";
					sResult = "Ì";

					break;
				case 198: //I?
					sResult = "&#7880;";
					sResult = "?";

					break;
				case 211: //I~
					sResult = "&#296;";
					sResult = "I";

					break;
				case 210: //I.
					sResult = "&#7882;";
					sResult = "?";

					break;
				case 236: //i`
					sResult = "&igrave;";
					sResult = "ì";

					break;
				case 230: //i?
					sResult = "&#7881;";
					sResult = "?";

					break;
				case 243: //i~
					sResult = "&#297;";
					sResult = "i";

					break;
				case 242: //i.
					sResult = "&#7883;";
					sResult = "?";

					break;
				case 206: //Y.
					sResult = "&#7924;";
					sResult = "?";

					break;
				case 238: //y.
					sResult = "&#7925;";
					sResult = "?";

					break;
				default:
					sResult = szInput.ToString();
					break;
			}

			return sResult;
		}

		public static string CDoubleVNI(char szVowel, char szAccent)
		{
			//input : a vowel and its accent
			//output: Unicode equivalent

			string sChar = null;
			string sNextChar = null;
			string sOutput = null;

			sChar = szVowel.ToString();
			sNextChar = szAccent.ToString();
			sOutput = "";

			switch (System.Convert.ToInt32(sChar[0]))
			{
				case 65:
					//A
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 216:
							//grave À
							sOutput = (192).ToString();
							break;
						case 217:
							//acute Á
							sOutput = (193).ToString();
							break;
						case 219:
							//question ?
							sOutput = "&#7842;";
							sOutput = "?";
							break;
						case 213:
							//tilde Ã
							sOutput = (195).ToString();

							break;
						case 207:
							//dot
							sOutput = "&#7840;";
							sOutput = "?";
							break;
						case 194:
							//A^ (shared code 65 vith A)
							//A^
							sOutput = (194).ToString();
							break;
						case 192:
							//grave ?
							sOutput = "&#7846;";
							sOutput = "?";
							break;
						case 193:
							//acute
							sOutput = "&#7844;";
							sOutput = "?";
							break;
						case 197:
							//question
							sOutput = "&#7848;";
							sOutput = "?";
							break;
						case 195:
							//tilde
							sOutput = "&#7850;";
							sOutput = "?";
							break;
						case 196:
							//dot
							sOutput = "&#7852;";
							sOutput = "?";
							break;
						case 202:
							//A( note: sharing code with A
							sOutput = "&#258;";
							sOutput = "A";
							break;
						case 200:
							//grave d?u huy?n
							sOutput = "&#7856;";
							sOutput = "?";

							break;
						case 201:
							//acute s?c
							sOutput = "&#7854;";
							sOutput = "?";

							break;
						case 218:
							//question
							sOutput = "&#7858;";
							sOutput = "?";

							break;
						case 220:
							//tilde
							sOutput = "&#7860;";
							sOutput = "?";

							break;
						case 203:
							//dot
							sOutput = "&#7862;";
							sOutput = "?";
							break;
					}

					break;
				case 97: //a
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 248:
							//grave
							sOutput = (224).ToString();

							break;
						case 249:
							//acute
							sOutput = (225).ToString();

							break;
						case 251:
							//question
							sOutput = "&#7843;";
							sOutput = "?";

							break;
						case 245:
							//tilde
							sOutput = "&atilde;";
							sOutput = "ã";

							break;
						case 239:
							//dot
							sOutput = "&#7841;";
							sOutput = "?";

							break;
						case 226:
							//a^ (sharing code with a)
							sOutput = (226).ToString();
							sOutput = "â";

							break;
						case 224:
							//grave
							sOutput = "&#7847;";
							sOutput = "?";

							break;
						case 225:
							//acute
							sOutput = "&#7845;";
							sOutput = "?";

							break;
						case 229:
							//question
							sOutput = "&#7849;";
							sOutput = "?";

							break;
						case 227:
							//tilde
							sOutput = "&#7851;";
							sOutput = "?";

							break;
						case 228:
							//dot
							sOutput = "&#7853;";
							sOutput = "?";

							break;
						case 234:
							//a( note: sharing code with a
							sOutput = "&#259;";
							sOutput = "a";

							break;
						case 232:
							//grave
							sOutput = "&#7857;";
							sOutput = "?";

							break;
						case 233:
							//acute
							sOutput = "&#7855;";
							sOutput = "?";

							break;
						case 250:
							//question
							sOutput = "&#7859;";
							sOutput = "?";

							break;
						case 252:
							//tilde
							sOutput = "&#7861;";
							sOutput = "?";

							break;
						case 235:
							//dot
							sOutput = "&#7863;";
							sOutput = "?";
							break;
					}

					break;
				case 69: //E
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 216:
							//grave
							sOutput = (200).ToString();

							break;
						case 217:
							//acute
							sOutput = (201).ToString();

							break;
						case 219:
							//question
							sOutput = "&#7866;";
							sOutput = "?";

							break;
						case 213:
							//tilde
							sOutput = "&#7868;";
							sOutput = "?";

							break;
						case 207:
							//dot
							sOutput = "&#7864;";
							sOutput = "?";

							break;
						case 194:
							//E^ note: sharing code with E
							sOutput = (202).ToString();

							break;
						case 192:
							//grave
							sOutput = "&#7872;";
							sOutput = "?";

							break;
						case 193:
							//acute
							sOutput = "&#7870;";
							sOutput = "?";

							break;
						case 197:
							//question
							sOutput = "&#7874;";
							sOutput = "?";

							break;
						case 195:
							//tilde
							sOutput = "&#7876;";
							sOutput = "?";

							break;
						case 196:
							//dot
							sOutput = "&#7878;";
							sOutput = "?";
							break;
					}

					break;
				case 101: //e
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 248:
							//grave
							sOutput = (232).ToString();
							sOutput = "è";

							break;
						case 249:
							//acute
							sOutput = (233).ToString();
							sOutput = "é";

							break;
						case 251:
							//question
							sOutput = "&#7867;";
							sOutput = "?";

							break;
						case 245:
							//tilde
							sOutput = "&#7869;";
							sOutput = "?";

							break;
						case 239:
							//dot
							sOutput = "&#7865;";
							sOutput = "?";

							break;
						case 226:
							//e^ note: sharing code with e
							sOutput = (234).ToString();

							break;
						case 224:
							//grave
							sOutput = "&#7873;";
							sOutput = "?";

							break;
						case 225:
							//acute
							sOutput = "&#7871;";
							sOutput = "?";

							break;
						case 229:
							//question
							sOutput = "&#7875;";
							sOutput = "?";

							break;
						case 227:
							//tilde
							sOutput = "&#7877;";
							sOutput = "?";

							break;
						case 228:
							//dot
							sOutput = "&#7879;";
							sOutput = "?";
							break;
					}

					//I(Case 73) not applicable
					//i (Case 105) not applicable

					break;
				case 79: //O
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 216:
							//grave
							sOutput = "&Ograve;";
							sOutput = "Ò";

							break;
						case 217:
							//acute
							sOutput = (211).ToString();

							break;
						case 219:
							//question
							sOutput = "&#7886;";
							sOutput = "?";

							break;
						case 213:
							//tilde
							sOutput = "&Otilde;";
							sOutput = "Õ";

							break;
						case 207:
							//dot
							sOutput = "&#7884;";
							sOutput = "?";

							//O^ note: sharing code with O
							break;
						case 194:
							sOutput = (212).ToString();

							break;
						case 192:
							//grave
							sOutput = "&#7890;";
							sOutput = "?";

							break;
						case 193:
							//acute
							sOutput = "&#7888;";
							sOutput = "?";

							break;
						case 197:
							//question
							sOutput = "&#7892;";
							sOutput = "?";

							break;
						case 195:
							//tilde
							sOutput = "&#7894;";
							sOutput = "?";

							break;
						case 196:
							//dot
							sOutput = "&#7896;";
							sOutput = "?";
							break;
					}

					//o
					break;
				case 111:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 248:
							//grave
							sOutput = "&ograve;";
							sOutput = "ò";

							break;
						case 249:
							//acute
							sOutput = (243).ToString();

							break;
						case 251:
							//question
							sOutput = "&#7887;";
							sOutput = "?";

							break;
						case 245:
							//tilde
							sOutput = "&otilde;";
							sOutput = "õ";

							break;
						case 239:
							//dot
							sOutput = "&#7885;";
							sOutput = "?";

							//o^ note: sharing code with o
							break;
						case 226:
							sOutput = (244).ToString();
							//sOutput = "?"

							break;
						case 224:
							//grave
							sOutput = "&#7891;";
							sOutput = "?";

							break;
						case 225:
							//acute
							sOutput = "&#7889;";
							sOutput = "?";

							break;
						case 229:
							//question
							sOutput = "&#7893;";
							sOutput = "?";

							break;
						case 227:
							//tilde
							sOutput = "&#7895;";
							sOutput = "?";

							break;
						case 228:
							//dot
							sOutput = "&#7897;";
							sOutput = "?";
							break;
					}

					//ký t? gì v?y nè
					//O
					break;
				case 212:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 216:
							//grave
							sOutput = "&#7900;";
							sOutput = "?";

							break;
						case 217:
							//acute
							sOutput = "&#7898;";
							sOutput = "?";

							break;
						case 219:
							//question
							sOutput = "&#7902;";
							sOutput = "?";

							break;
						case 213:
							//tilde
							sOutput = "&#7904;";
							sOutput = "?";

							break;
						case 207:
							//dot
							sOutput = "&#7906;";
							sOutput = "?";
							break;
					}

					//o
					break;
				case 244:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 248:
							//grave
							sOutput = "&#7901;";
							sOutput = "?";

							break;
						case 249:
							//acute
							sOutput = "&#7899;";
							sOutput = "?";

							break;
						case 251:
							//question
							sOutput = "&#7903;";
							sOutput = "?";

							break;
						case 245:
							//tilde
							sOutput = "&#7905;";
							sOutput = "?";

							break;
						case 239:
							//dot
							sOutput = "&#7907;";
							sOutput = "?";
							break;
					}

					//U
					break;
				case 85:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 216:
							//grave
							sOutput = (217).ToString();
							break;
						case 217:
							//acute
							sOutput = (218).ToString();

							break;
						case 219:
							//question
							sOutput = "&#7910;";
							sOutput = "?";

							break;
						case 213:
							//tilde
							sOutput = "&#360;";
							sOutput = "U";

							break;
						case 207:
							//dot
							sOutput = "&#7908;";
							sOutput = "?";
							break;
					}

					break;
				case 117: //u
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 248:
							//grave
							sOutput = (249).ToString();
							break;
						case 249:
							//acute
							sOutput = (250).ToString();

							break;
						case 251:
							//question
							sOutput = "&#7911;";
							sOutput = "?";

							break;
						case 245:
							//tilde
							sOutput = "&#361;";
							sOutput = "u";

							break;
						case 239:
							//dot
							sOutput = "&#7909;";
							sOutput = "?";
							break;
					}

					//U)
					break;
				case 214:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 216:
							//grave
							sOutput = "&#7914;";
							sOutput = "?";

							break;
						case 217:
							//acute
							sOutput = "&#7912;";
							sOutput = "?";

							break;
						case 219:
							//question
							sOutput = "&#7916;";
							sOutput = "?";

							break;
						case 213:
							//tilde
							sOutput = "&#7918;";
							sOutput = "?";

							break;
						case 207:
							//dot
							sOutput = "&#7920;";
							sOutput = "?";
							break;
					}

					//u)
					break;
				case 246:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 248:
							//grave
							sOutput = "&#7915;";
							sOutput = "?";
							break;
						case 249:
							//acute
							sOutput = "&#7913;";
							sOutput = "?";

							break;
						case 251:
							//question
							sOutput = "&#7917;";
							sOutput = "?";

							break;
						case 245:
							//tilde
							sOutput = "&#7919;";
							sOutput = "?";

							break;
						case 239:
							//dot
							sOutput = "&#7921;";
							sOutput = "?";
							break;
						default:
							sOutput = "&#432;" + sNextChar;
							sOutput = "u" + sNextChar;
							break;
					}

					//Y
					break;
				case 89:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 216:
							//grave
							sOutput = "&#7922;";
							sOutput = "?";

							break;
						case 217:
							//acute
							sOutput = "&Yacute;";
							sOutput = "Ý";

							break;
						case 219:
							//question
							sOutput = "&#7926;";
							sOutput = "?";

							break;
						case 213:
							//tilde d?u ngã
							sOutput = "&#7928;";
							sOutput = "?";

							//dot: already handled by CSingleVNI()
							break;
					}

					//y
					break;
				case 121:
					switch (System.Convert.ToInt32(sNextChar[0]))
					{
						case 248:
							//grave
							sOutput = "&#7923;";
							sOutput = "?";

							break;
						case 249:
							//acute
							sOutput = "&yacute;";
							sOutput = "ý";

							break;
						case 251:
							//question
							sOutput = "&#7927;";
							sOutput = "?";

							break;
						case 245:
							//tilde
							sOutput = "&#7929;";
							sOutput = "?";

							//dot: already handled by CSingleVNI()
							break;
					}
					break;
			}

			return sOutput;
		}

		public static bool CheckVNIAccent(char szInput)
		{
			//check if an accent character is there
			switch (System.Convert.ToInt32(szInput))
			{
				case 248:
				case 249:
				case 251:
				case 245:
				case 239:
					//Small: ` ' ? ~ .
					return true;

				case 234:
				case 232:
				case 233:
				case 250:
				case 252:
				case 235:
					//Small (, (`, (', (?, (~, (.
					return true;

				case 226:
				case 224:
				case 225:
				case 229:
				case 227:
				case 228:
					//Small ^, ^`, ^', ^?, ^~, ^.	
					return true;

				case 216:
				case 217:
				case 219:
				case 213:
				case 207:
					//Big ` ' ? ~ .
					return true;

				case 202:
				case 200:
				case 201:
				case 218:
				case 220:
				case 203:
					//Big (, (`, (', (?, (~, (.
					return true;

				case 194:
				case 192:
				case 193:
				case 197:
				case 195:
				case 196:
					//Big ^, ^`, ^', ^?, ^~, ^.	
					return true;

				default:
					return false;
			}

		}

		public static bool CheckVNIVowel(char szInput)
		{

			switch (System.Convert.ToInt32(szInput))
			{
				case 65:
				case 69:
				case 79:
				case 212:
				case 85:
				case 214:
					//A, E, O, O), U, U)
					return true;

				case 97:
				case 101:
				case 111:
				case 244:
				case 117:
				case 246:
					//a, e, o, o), u, u)
					return true;

				case 73:
				case 105:
				case 89:
				case 121:
					//I, i, Y, y
					return true;
				default:
					return false;
			}


		}

	#region Các hàm liên quan nhap bang Unicode
		/// <summary>
		/// Chuyen các control sang nhap lieu Uniocde
		/// </summary>
		/// <param name="control"></param>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static void InputbyUnicode(Control control)
		{
			if (! cls_GlobalUtil.gbInputbyUnicode)
			{
				return;
			}

			foreach (Control ctrl in control.Controls)
			{
				if ((ctrl) is TextBox)
				{
					if (((TextBox)ctrl).ReadOnly == false)
					{
						ctrl.Font = new Font("Microsoft Sans Serif", 8.25F);
						continue;
					}
				}
				else if ((ctrl) is TabControl | (ctrl) is TabPage | (ctrl) is GroupBox | (ctrl) is Panel)
				{
					AdjustFontChildControl(ctrl);
				}
			}
		}

		private static void AdjustFontChildControl(Control ctrl)
		{
			if ((ctrl) is TextBox)
			{
				if (((TextBox)ctrl).ReadOnly == false)
				{
                   ctrl.Font = new Font("Microsoft Sans Serif", 8.25F);
				}
				return;
			}
			else if ((ctrl) is TabControl | (ctrl) is TabPage | (ctrl) is GroupBox | (ctrl) is Panel)
			{
				foreach (Control childControl in ctrl.Controls)
				{
					AdjustFontChildControl(childControl);
				}
			}
			else
			{
				return;
			}
		}

		
		/// <summary>
		/// Chuyen doi dang unicode sang VNI
		/// </summary>
		/// <param name="vnstr"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static string ConvertUnicodeToVni(string vnstr)
		{
			string Result = "";
			string c = "";
				int i = 0;
			for (i = 1; i <= vnstr.Length; i++)
			{
				c = vnstr.Substring(i - 1, 1);
				if (c == (97).ToString())
				{
					c = "a";
				}
				else if (c == (225).ToString())
				{
					c = "aù";
				}
				else if (c == (224).ToString())
				{
					c = "aø";
				}
				else if (c == (7843).ToString())
				{
					c = "aû";
				}
				else if (c == (227).ToString())
				{
					c = "aõ";
				}
				else if (c == (7841).ToString())
				{
					c = "aï";
				}
				else if (c == (259).ToString())
				{
					c = "aê";
				}
				else if (c == (7855).ToString())
				{
					c = "aé";
				}
				else if (c == (7857).ToString())
				{
					c = "aè";
				}
				else if (c == (7859).ToString())
				{
					c = "aú";
				}
				else if (c == (7861).ToString())
				{
					c = "aü";
				}
				else if (c == (7863).ToString())
				{
					c = "aë";
				}
				else if (c == (226).ToString())
				{
					c = "aâ";
				}
				else if (c == (7845).ToString())
				{
					c = "aá";
				}
				else if (c == (7847).ToString())
				{
					c = "aà";
				}
				else if (c == (7849).ToString())
				{
					c = "aå";
				}
				else if (c == (7851).ToString())
				{
					c = "aã";
				}
				else if (c == (7853).ToString())
				{
					c = "aä";
				}
				else if (c == (101).ToString())
				{
					c = "e";
				}
				else if (c == (233).ToString())
				{
					c = "eù";
				}
				else if (c == (232).ToString())
				{
					c = "eø";
				}
				else if (c == (7867).ToString())
				{
					c = "eû";
				}
				else if (c == (7869).ToString())
				{
					c = "eõ";
				}
				else if (c == (7865).ToString())
				{
					c = "eï";
				}
				else if (c == (234).ToString())
				{
					c = "eâ";
				}
				else if (c == (7871).ToString())
				{
					c = "eá";
				}
				else if (c == (7873).ToString())
				{
					c = "eà";
				}
				else if (c == (7875).ToString())
				{
					c = "eå";
				}
				else if (c == (7877).ToString())
				{
					c = "eã";
				}
				else if (c == (7879).ToString())
				{
					c = "eä";
				}
				else if (c == (111).ToString())
				{
					c = "o";
				}
				else if (c == (243).ToString())
				{
					c = "où";
				}
				else if (c == (242).ToString())
				{
					c = "oø";
				}
				else if (c == (7887).ToString())
				{
					c = "oû";
				}
				else if (c == (245).ToString())
				{
					c = "oõ";
				}
				else if (c == (7885).ToString())
				{
					c = "oï";
				}
				else if (c == (244).ToString())
				{
					c = "oâ";
				}
				else if (c == (7889).ToString())
				{
					c = "oá";
				}
				else if (c == (7891).ToString())
				{
					c = "oà";
				}
				else if (c == (7893).ToString())
				{
					c = "oå";
				}
				else if (c == (7895).ToString())
				{
					c = "oã";
				}
				else if (c == (7897).ToString())
				{
					c = "oä";
				}
				else if (c == (417).ToString())
				{
					c = "ô";
				}
				else if (c == (7899).ToString())
				{
					c = "ôù";
				}
				else if (c == (7901).ToString())
				{
					c = "ôø";
				}
				else if (c == (7903).ToString())
				{
					c = "ôû";
				}
				else if (c == (7905).ToString())
				{
					c = "ôõ";
				}
				else if (c == (7907).ToString())
				{
					c = "ôï";
				}
				else if (c == (105).ToString())
				{
					c = "i";
				}
				else if (c == (237).ToString())
				{
					c = "í";
				}
				else if (c == (236).ToString())
				{
					c = "ì";
				}
				else if (c == (7881).ToString())
				{
					c = "æ";
				}
				else if (c == (297).ToString())
				{
					c = "ó";
				}
				else if (c == (7883).ToString())
				{
					c = "ò";
				}
				else if (c == (117).ToString())
				{
					c = "u";
				}
				else if (c == (250).ToString())
				{
					c = "uù";
				}
				else if (c == (249).ToString())
				{
					c = "uø";
				}
				else if (c == (7911).ToString())
				{
					c = "uû";
				}
				else if (c == (361).ToString())
				{
					c = "uõ";
				}
				else if (c == (7909).ToString())
				{
					c = "uï";
				}
				else if (c == (432).ToString())
				{
					c = "ö";
				}
				else if (c == (7913).ToString())
				{
					c = "öù";
				}
				else if (c == (7915).ToString())
				{
					c = "uø";
				}
				else if (c == (7917).ToString())
				{
					c = "öû";
				}
				else if (c == (7919).ToString())
				{
					c = "öõ";
				}
				else if (c == (7921).ToString())
				{
					c = "öï";
				}
				else if (c == (121).ToString())
				{
					c = "y";
				}
				else if (c == (253).ToString())
				{
					c = "yù";
				}
				else if (c == (7923).ToString())
				{
					c = "yø";
				}
				else if (c == (7927).ToString())
				{
					c = "yû";
				}
				else if (c == (7929).ToString())
				{
					c = "yõ";
				}
				else if (c == (7925).ToString())
				{
					c = "î";
				}
				else if (c == (273).ToString())
				{
					c = "ñ";
				}
				else if (c == (65).ToString())
				{
					c = "A";
				}
				else if (c == (193).ToString())
				{
					c = "AÙ";
				}
				else if (c == (192).ToString())
				{
					c = "AØ";
				}
				else if (c == (7842).ToString())
				{
					c = "AÛ";
				}
				else if (c == (195).ToString())
				{
					c = "AÕ";
				}
				else if (c == (7840).ToString())
				{
					c = "AÏ";
				}
				else if (c == (258).ToString())
				{
					c = "AÊ";
				}
				else if (c == (7854).ToString())
				{
					c = "AÉ";
				}
				else if (c == (7856).ToString())
				{
					c = "AÈ";
				}
				else if (c == (7858).ToString())
				{
					c = "AÚ";
				}
				else if (c == (7860).ToString())
				{
					c = "AÜ";
				}
				else if (c == (7862).ToString())
				{
					c = "AË";
				}
				else if (c == (194).ToString())
				{
					c = "AÂ";
				}
				else if (c == (7844).ToString())
				{
					c = "AÁ";
				}
				else if (c == (7846).ToString())
				{
					c = "AÀ";
				}
				else if (c == (7848).ToString())
				{
					c = "AÅ";
				}
				else if (c == (7850).ToString())
				{
					c = "AÃ";
				}
				else if (c == (7852).ToString())
				{
					c = "AÄ";
				}
				else if (c == (69).ToString())
				{
					c = "E";
				}
				else if (c == (201).ToString())
				{
					c = "EÙ";
				}
				else if (c == (200).ToString())
				{
					c = "EØ";
				}
				else if (c == (7866).ToString())
				{
					c = "EÛ";
				}
				else if (c == (7868).ToString())
				{
					c = "EÕ";
				}
				else if (c == (7864).ToString())
				{
					c = "EÏ";
				}
				else if (c == (202).ToString())
				{
					c = "EÂ";
				}
				else if (c == (7870).ToString())
				{
					c = "EÁ";
				}
				else if (c == (7872).ToString())
				{
					c = "EÀ";
				}
				else if (c == (7874).ToString())
				{
					c = "EÅ";
				}
				else if (c == (7876).ToString())
				{
					c = "EÃ";
				}
				else if (c == (7878).ToString())
				{
					c = "EÄ";
				}
				else if (c == (79).ToString())
				{
					c = "O";
				}
				else if (c == (211).ToString())
				{
					c = "OÙ";
				}
				else if (c == (210).ToString())
				{
					c = "OØ";
				}
				else if (c == (7886).ToString())
				{
					c = "OÛ";
				}
				else if (c == (213).ToString())
				{
					c = "OÕ";
				}
				else if (c == (7884).ToString())
				{
					c = "OÏ";
				}
				else if (c == (212).ToString())
				{
					c = "OÂ";
				}
				else if (c == (7888).ToString())
				{
					c = "OÁ";
				}
				else if (c == (7890).ToString())
				{
					c = "OÀ";
				}
				else if (c == (7892).ToString())
				{
					c = "OÅ";
				}
				else if (c == (7894).ToString())
				{
					c = "OÃ";
				}
				else if (c == (7896).ToString())
				{
					c = "OÄ";
				}
				else if (c == (416).ToString())
				{
					c = "Ô";
				}
				else if (c == (7898).ToString())
				{
					c = "ÔÙ";
				}
				else if (c == (7900).ToString())
				{
					c = "ÔØ";
				}
				else if (c == (7902).ToString())
				{
					c = "ÔÛ";
				}
				else if (c == (7904).ToString())
				{
					c = "ÔÕ";
				}
				else if (c == (7906).ToString())
				{
					c = "ÔÏ";
				}
				else if (c == (73).ToString())
				{
					c = "I";
				}
				else if (c == (205).ToString())
				{
					c = "Í";
				}
				else if (c == (204).ToString())
				{
					c = "Ì";
				}
				else if (c == (7880).ToString())
				{
					c = "Æ";
				}
				else if (c == (296).ToString())
				{
					c = "Ó";
				}
				else if (c == (7882).ToString())
				{
					c = "Ò";
				}
				else if (c == (85).ToString())
				{
					c = "U";
				}
				else if (c == (218).ToString())
				{
					c = "UÙ";
				}
				else if (c == (217).ToString())
				{
					c = "UØ";
				}
				else if (c == (7910).ToString())
				{
					c = "UÛ";
				}
				else if (c == (360).ToString())
				{
					c = "UÕ";
				}
				else if (c == (7908).ToString())
				{
					c = "UÏ";
				}
				else if (c == (431).ToString())
				{
					c = "Ö";
				}
				else if (c == (7912).ToString())
				{
					c = "ÖÙ";
				}
				else if (c == (7914).ToString())
				{
					c = "ÖØ";
				}
				else if (c == (7916).ToString())
				{
					c = "ÖÛ";
				}
				else if (c == (7918).ToString())
				{
					c = "ÖÕ";
				}
				else if (c == (7920).ToString())
				{
					c = "ÖÏ";
				}
				else if (c == (89).ToString())
				{
					c = "Y";
				}
				else if (c == (221).ToString())
				{
					c = "YÙ";
				}
				else if (c == (7922).ToString())
				{
					c = "YØ";
				}
				else if (c == (7926).ToString())
				{
					c = "YÛ";
				}
				else if (c == (7928).ToString())
				{
					c = "YÕ";
				}
				else if (c == (7924).ToString())
				{
					c = "Î";
				}
                else if (c == (272).ToString())
				{
					c = "Ñ";
				}
				Result += c;
			}
			return Result;
		}

		/// <summary>
		/// Chuyen du lieu cua Table sang Unicode
		/// </summary>
		/// <param name="dt"></param>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static void ConvertVniToUnicode(ref DataTable dt)
		{
			for (int i = 0; i < dt.Rows.Count; i++) //S? dòng
			{
				for (int j = 0; j < dt.Columns.Count; j++) //S? c?t
				{
					if (! (dt.Rows[i].IsNull(j)))
					{
						dt.Rows[i][j] = ConvertVniToUnicode(dt.Rows[i][j].ToString());
					}
				}
			}
		}

		/// <summary>
		/// Chuyen Vni sang Unicode cho các cot cua table
		/// </summary>
		/// <param name="dt"></param>
		/// <param name="myStrArray"> Dim myStrArray() As String = {"RelationName", "RelativeName'} </param>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static void ConvertDataTable(ref DataTable dt, string[] myStrArray)
		{
			for (int i = 0; i < dt.Rows.Count; i++) //S? dòng
			{
				for (int j = 0; j < myStrArray.Length; j++) //S? c?t
				{
					if (! (dt.Rows[i].IsNull(j)))
					{
						dt.Rows[i][myStrArray[j]] = ConvertVniToUnicode(dt.Rows[i][myStrArray[j]].ToString());
					}
				}
			}
		}

		[DebuggerStepThrough()]
		public static bool ConvertDataTable(DataTable dt, ArrayList arr)
		{
			if (dt == null)
			{
				return false;
			}

			int j = 0;
				int k = 0;

			for (j = 0; j < dt.Rows.Count; j++)
			{
				for (k = 0; k < dt.Columns.Count; k++)
				{
					if (arr.Contains(dt.Columns[k].ColumnName))
					{
						if (! (dt.Rows[j].IsNull(k)))
						{
							dt.Rows[j][k] = ConvertVniToUnicode(dt.Rows[j][k].ToString());
						}
					}
				}
			}

			return false;
		}

		/// <summary>
		/// Chuyen Vni sang Unicode cho các cot cua datarow
		/// </summary>
		/// <param name="dr"></param>
		/// <param name="myStrArray"> Dim myStrArray() As String = {"RelationName", "RelativeName'} </param>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static void ConvertDataRow(ref DataRow dr, string[] myStrArray)
		{
			for (int i = 0; i < myStrArray.Length; i++) //So cot
			{
				if (! (dr.IsNull(i)))
				{
					dr[myStrArray[i]] = ConvertVniToUnicode(dr[myStrArray[i]].ToString());
				}
			}
		}

		[DebuggerStepThrough()]
		public static bool ConvertDataView(System.Data.DataView dtView, string Column)
		{
			if (dtView == null)
			{
				return false;
			}

			int j = 0;
			try
			{
				for (j = 0; j < dtView.Count; j++)
				{
					if (System.Convert.IsDBNull(dtView[j][Column]))
					{
					}
					else
					{
						dtView[j][Column] = ConvertVniToUnicode(dtView[j][Column].ToString());
					}
				}
			}
			catch (Exception ex)
			{
                if (cls_GlobalUtil.OptSys.Language == 0)
                {
                    MessageBox.Show(ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                }
                else
                {
                    MessageBox.Show(ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                }
            }
           return false;
		}

	#endregion
	}

} //end of root namespace