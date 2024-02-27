// Es crear un objecte System.Drawing.Printing.PrintDocument.
private System.Drawing.Printing.PrintDocument docToPrint = 
    new System.Drawing.Printing.PrintDocument();

// Afegirem els atributs de la finestra de imprimir 
// També imprimirem el dialeg dins de la finestra
private void Button1_Click(System.Object sender, 
    System.EventArgs e)
{

    // Opció per elegir quines pàgines vols imprimir
    PrintDialog1.AllowSomePages = true;

    // Introdueix el botó d'ajuda a la finestra
    PrintDialog1.ShowHelp = true;

    // Ensenya la finestra
    PrintDialog1.Document = docToPrint;

    DialogResult result = PrintDialog1.ShowDialog();

    // Si l'usuari apreta okay, llavors imprimeix.
    if (result==DialogResult.OK)
    {
        docToPrint.Print();
    }
}

// Crearem un event amb el qual enviarem l'ordre d'impressió
private void document_PrintPage(object sender, 
    System.Drawing.Printing.PrintPageEventArgs e)
{


    // Introdueix un missatge a l'hora de imprimir
    string text = "In document_PrintPage method.";
    System.Drawing.Font printFont = new System.Drawing.Font
        ("Arial", 35, System.Drawing.FontStyle.Regular);

    // Imprimeix el contingut
    e.Graphics.DrawString(text, printFont, 
        System.Drawing.Brushes.Black, 10, 10);
}
