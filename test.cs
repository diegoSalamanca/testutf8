using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/userData", order = 1)]

[System.Serializable]

public class UserData : ScriptableObject
{
    [Header("----------Practice Data----------")]

    public string practiceName;

    public string lastScene; 

    public string PlayerSelected;  

    public Vector3 position;

    public Quaternion rot;

    [Header("----------Student Data----------")]
    public string name;
    public int edad;

    public string email;   

    [Header ("------------Notas Usuario----------")]
    [TextArea]
    public string notasUsuario;

    [Header("----------Final Results----------")]

    public int experience;
    public string time;
    public int goodAnswer;
    public int badAnswer;

    [Header("----------Datos de Excel----------")]

    public string templateName;
    
    public string fileName;

    public List<VpSerializableData.ExcelPage> excelReport; 

    [Header("----------Inventario----------")]
    
    public List<VpSerializableData.InventoryItem> inventory; 

    [Header("----------MailData----------")]
    
    public string reportUrl;    
    public string institution;
    public string academicProgram;
    public string subject;
    public string studentCode;
    public string teacherName;
    public string teacherEmail;



    [Header("---------- Practice SAVE ----------")]

    public bool practiceStarted;
    public string UserName, UserLastName, IdNumber;

    public bool instructionsStarted;
    public List<DialogueNodeData> dialogueNodeDatas;
    public int step;

    public bool valuesStarted;
    public ValuesResumeData valuesResumeData;

    public bool productosAñoStarted;
    public TestBaquero.ProductsYear productsYear;

    public bool notesStarted;
    public List<bool> notesActivated;

    public bool uniforme;
    public bool excelStarted;

    public string tiempoTotal;
    public float currentProgress;

    public bool xpForNotesAssigned;

    [ContextMenu("Default")]
    public void Default()
    {
        practiceName = "Plan Maestro De Producción";
        templateName = "ap28";
        fileName = "Resultados_PlanMaestroDeProduccion";

        lastScene = "";
        PlayerSelected = "0";
        position = new Vector3();
        rot = new Quaternion();

        notasUsuario = "";

        experience = 0;
        time = "";
        goodAnswer = 0;
        badAnswer = 0;

        excelReport.Clear();
        inventory.Clear();

        practiceStarted = false;
        UserName = "";
        UserLastName = "";
        IdNumber = "";
        instructionsStarted = false;
        dialogueNodeDatas.Clear();
        step = 0;
        valuesStarted = false;
        valuesResumeData = null;
        productosAñoStarted = false;
        productsYear = null;
        notesStarted = false;
        notesActivated.Clear();
        uniforme = false;
        excelStarted = false;
        tiempoTotal = "";
        currentProgress = 0;
        xpForNotesAssigned = false;
    }
}
