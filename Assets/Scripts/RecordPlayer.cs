using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordPlayer : MonoBehaviour {

    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;
    public Text player5;
    public Text player6;
    public Text player7;
    public Text player8;
    public Text player9;
    public Text player10;
    public Text player11;
    public Text player12;
    public Text player13;
    public Text player14;
    public Text player15;
    public Text player16;
    public Text player17;
    public Text player18;
    public Text player19;
    public Text player20;
    public Text player21;
    public Text player22;
    public Text player23;
    public Text player24;
    public Text player25;
    public Text player26;
    public Text player27;
    public Text player28;
    public Text player29;
    public Text player30;
    public Text player31;
    public Text player32;
    public Text player33;
    public Text player34;
    public Text player35;
    public Text player36;
    public Text player37;
    public Text player38;
    public Text player39;
    public Text player40;
    public Text player41;
    public Text player42;
    public Text player43;
    public Text player44;
    public Text player45;
    public Text player46;
    public Text player47;
    public Text player48;
    public Text player49;
    public Text player50;

    public int maxRecord;
    private int i, j;


    void Start()
    {
        maxRecord = PlayerPrefs.GetInt("Record");
        string[] playerRecord = new string[50] { "mikhail195", "shevcov77", "xAngeLx", "vlomiam", "Maelslev", "oskar61", "wanderer_from", "amaze777", "Z1KkY1", "Crysler45", "heletch", "shipilov", "Chacha99",
            "Dr_Dizel","RaNDoM88","sport1k","Su1c1de","RogerTwo","glx506","volandband","pas543","Necron","edik_lukoyanov","Synchromesh","SolomA65","Dron128","DeatHSoul","DangErXeTER","Psy7777","Forcas1","Morgot34",
            "NuBl","djogot","isaak_rozovsky","OlegDex","Amigo123","DJ_SiD","alegz","IzyLed","SloodyKnight","D1nq","Nek_Morte","Alf555","mozarthead","KoSs444","alex_mezinskiy","TAXD999", "NikolayTrofimov","tess666","Ваш рекорд"};
        int[] mas = new int[50] {77, 269, 540, 604, 740, 850, 985, 1001, 1002, 1123, 1332, 1523, 1931, 1993, 2123, 2321,
            2521, 2724, 2900, 3002, 3021, 3120, 3404, 3707, 3918, 4002, 4023, 4321, 4508, 4721, 5043, 5221, 5704, 6234, 6504, 6894, 7121, 7409, 7893, 8432, 8700, 9021, 10321, 11003, 12392, 13503, 15203, 17012, 17402, maxRecord };

        //Сортировка массива
        for (int i = 0; i < 50 - 1; i++)
        {
            for (int j = 0; j < 50 - 1; j++)
            {
                if (mas[j] > mas[j + 1])
                {
                    int tmp = mas[j];
                    mas[j] = mas[j + 1];
                    mas[j + 1] = tmp;

                    string changePlayer = playerRecord[j];
                    playerRecord[j] = playerRecord[j + 1];
                    playerRecord[j + 1] = changePlayer;
                }
            }
        }

        

        player1.text = "1. " + playerRecord[0] + " - " + mas[0].ToString() + "сек";
		player2.text = "2. " + playerRecord[1] + " - " + mas[1].ToString() + "сек";
		player3.text = "3. " + playerRecord[2] + " - " +  mas[2].ToString() + "сек";
		player4.text = "4. " + playerRecord[3] + " - " +  mas[3].ToString() + "сек";
		player5.text = "5. " + playerRecord[4] + " - " +  mas[4].ToString() + "сек";
		player6.text = "6. " + playerRecord[5] + " - " + mas[5].ToString() + "сек";
		player7.text = "7. " + playerRecord[6] + " - " +  mas[6].ToString() + "сек";
		player8.text = "8. " + playerRecord[7] + " - " +  mas[7].ToString() + "сек";
		player9.text = "9. " + playerRecord[8] + " - " +  mas[8].ToString() + "сек";
		player10.text = "10. " + playerRecord[9] + " - " +  mas[9].ToString() + "сек";
		player11.text = "11. " + playerRecord[10] + " - " +  mas[10].ToString() + "сек";
		player12.text = "12. " + playerRecord[11] + " - " +  mas[11].ToString() + "сек";
		player13.text = "13. " + playerRecord[12] + " - " +  mas[12].ToString() + "сек";
		player14.text = "14. " + playerRecord[13] + " - " +  mas[13].ToString() + "сек";
		player15.text = "15. " + playerRecord[14] + " - " + mas[14].ToString() + "сек";
		player16.text = "16. " + playerRecord[15] + " - " +  mas[15].ToString() + "сек";
		player17.text = "17. " + playerRecord[16] + " - " +  mas[16].ToString() + "сек";
		player18.text = "18. " + playerRecord[17] + " - " +  mas[17].ToString() + "сек";
		player19.text = "19. " + playerRecord[18] + " - " + mas[18].ToString() + "сек";
		player20.text = "20. " + playerRecord[19] + " - " +  mas[19].ToString() + "сек";
		player21.text = "21. " + playerRecord[20] + " - " +  mas[20].ToString() + "сек";
		player22.text = "22. " + playerRecord[21] + " - " +  mas[21].ToString() + "сек";
		player23.text = "23. " + playerRecord[22] + " - " + mas[22].ToString() + "сек";
		player24.text = "24. " + playerRecord[23] + " - " +  mas[23].ToString() + "сек";
		player25.text = "25. " + playerRecord[24] + " - " +  mas[24].ToString() + "сек";
		player26.text = "26. " + playerRecord[25] + " - " +  mas[25].ToString() + "сек";
		player27.text = "27. " + playerRecord[26] + " - " +  mas[26].ToString() + "сек";
		player28.text = "28. " + playerRecord[27] + " - " +  mas[27].ToString() + "сек";
		player29.text = "29. " + playerRecord[28] + " - " +  mas[28].ToString() + "сек";
		player30.text = "30. " + playerRecord[29] + " - " +  mas[29].ToString() + "сек";
		player31.text = "31. " + playerRecord[30] + " - " +  mas[30].ToString() + "сек";
		player32.text = "32. " + playerRecord[31] + " - " +  mas[31].ToString() + "сек";
		player33.text = "33. " + playerRecord[32] + " - " +  mas[32].ToString() + "сек";
		player34.text = "34. " + playerRecord[33] + " - " +  mas[33].ToString() + "сек";
		player35.text = "35. " + playerRecord[34] + " - " + mas[34].ToString() + "сек";
		player36.text = "36. " + playerRecord[35] + " - " +  mas[35].ToString() + "сек";
		player37.text = "37. " + playerRecord[36] + " - " +  mas[36].ToString() + "сек";
		player38.text = "38. " + playerRecord[37] + " - " +  mas[37].ToString() + "сек";
		player39.text = "39. " + playerRecord[38] + " - " + mas[38].ToString() + "сек";
		player40.text = "40. " + playerRecord[39] + " - " +  mas[39].ToString() + "сек";
		player41.text = "41. " + playerRecord[40] + " - " + mas[40].ToString() + "сек";
		player42.text = "42. " + playerRecord[41] + " - " +  mas[41].ToString() + "сек";
		player43.text = "43. " + playerRecord[42] + " - " +  mas[42].ToString() + "сек";
		player44.text = "44. " + playerRecord[43] + " - " +  mas[42].ToString() + "сек";
		player45.text = "45. " + playerRecord[44] + " - " +  mas[44].ToString() + "сек";
		player46.text = "46. " + playerRecord[45] + " - " +  mas[45].ToString() + "сек";
		player47.text = "47. " + playerRecord[46] + " - " + mas[46].ToString() + "сек";
		player48.text = "48. " + playerRecord[47] + " - " + mas[47].ToString() + "сек";
		player49.text = "49. " + playerRecord[48] + " - " +  mas[48].ToString() + "сек";
		player50.text = "... " + playerRecord[49] + " - " +  mas[49].ToString() + "сек";

        for (int i = 0; i < 50 - 1; i++)
        {
            if (mas[i] == PlayerPrefs.GetInt("Score"))
            {
                int topPosition = i + 1;
                switch(topPosition)
                {
                    case 1:
                        player1.color = new Color(216, 137, 19);
                        break;
                    case 2:
                        player2.color = new Color(216, 137, 19);
                        break;
                    case 3:
                        player3.color = new Color(216, 137, 19);
                        break;
                    case 4:
                        player4.color = new Color(216, 137, 19);
                        break;
                    case 5:
                        player5.color = new Color(216, 137, 19);
                        break;
                    case 6:
                        player6.color = new Color(216, 137, 19);
                        break;
                    case 7:
                        player7.color = new Color(216, 137, 19);
                        break;
                    case 8:
                        player8.color = new Color(216, 137, 19);
                        break;
                    case 9:
                        player9.color = new Color(216, 137, 19);
                        break;
                    case 10:
                        player10.color = new Color(216, 137, 19);
                        break;
                    case 11:
                        player11.color = new Color(216, 137, 19);
                        break;
                    case 12:
                        player12.color = new Color(216, 137, 19);
                        break;
                    case 13:
                        player13.color = new Color(216, 137, 19);
                        break;
                    case 14:
                        player14.color = new Color(216, 137, 19);
                        break;
                    case 15:
                        player15.color = new Color(216, 137, 19);
                        break;
                    case 16:
                        player16.color = new Color(216, 137, 19);
                        break;
                    case 17:
                        player17.color = new Color(216, 137, 19);
                        break;
                    case 18:
                        player18.color = new Color(216, 137, 19);
                        break;
                    case 19:
                        player19.color = new Color(216, 137, 19);
                        break;
                    case 20:
                        player20.color = new Color(216, 137, 19);
                        break;
                    case 21:
                        player21.color = new Color(216, 137, 19);
                        break;
                    case 22:
                        player22.color = new Color(216, 137, 19);
                        break;
                    case 23:
                        player23.color = new Color(216, 137, 19);
                        break;
                    case 24:
                        player24.color = new Color(216, 137, 19);
                        break;
                    case 25:
                        player25.color = new Color(216, 137, 19);
                        break;
                    case 26:
                        player26.color = new Color(216, 137, 19);
                        break;
                    case 27:
                        player27.color = new Color(216, 137, 19);
                        break;
                    case 28:
                        player28.color = new Color(216, 137, 19);
                        break;
                    case 29:
                        player29.color = new Color(216, 137, 19);
                        break;
                    case 30:
                        player30.color = new Color(216, 137, 19);
                        break;
                    case 31:
                        player31.color = new Color(216, 137, 19);
                        break;
                    case 32:
                        player32.color = new Color(216, 137, 19);
                        break;
                    case 33:
                        player33.color = new Color(216, 137, 19);
                        break;
                    case 34:
                        player34.color = new Color(216, 137, 19);
                        break;
                    case 35:
                        player35.color = new Color(216, 137, 19);
                        break;
                    case 36:
                        player36.color = new Color(216, 137, 19);
                        break;
                    case 37:
                        player37.color = new Color(216, 137, 19);
                        break;
                    case 38:
                        player38.color = new Color(216, 137, 19);
                        break;
                    case 39:
                        player39.color = new Color(216, 137, 19);
                        break;
                    case 40:
                        player40.color = new Color(216, 137, 19);
                        break;
                    case 41:
                        player41.color = new Color(216, 137, 19);
                        break;
                    case 42:
                        player42.color = new Color(216, 137, 19);
                        break;
                    case 43:
                        player43.color = new Color(216, 137, 19);
                        break;
                    case 44:
                        player44.color = new Color(216, 137, 19);
                        break;
                    case 45:
                        player45.color = new Color(216, 137, 19);
                        break;
                    case 46:
                        player46.color = new Color(216, 137, 19);
                        break;
                    case 47:
                        player47.color = new Color(216, 137, 19);
                        break;
                    case 48:
                        player48.color = new Color(216, 137, 19);
                        break;
                    case 49:
                        player49.color = new Color(216, 137, 19);
                        break;
                    case 50:
                        player50.color = new Color(216, 137, 19);
                        break;

                }
            }
        }

        



    }

	void Update () {
		
	}
}
