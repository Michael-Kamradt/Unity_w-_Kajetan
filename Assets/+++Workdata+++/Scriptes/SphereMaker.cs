using MyBox;
using UnityEngine;

public class SphereMaker : MonoBehaviour
{
    // Diese zwei Variablen geben an, wo die mittlere Kugel im Raum entstehen soll (X- und Y-Koordinate)
    public float positionOfSphereX;
    public float positionOfSphereY;

    // Hier speichern wir die mittlere Kugel, damit wir später darauf zugreifen können
    private GameObject _goMySphere;

    // Diese Methode erzeugt eine einzelne Kugel an der gewünschten Position
    [ButtonMethod]
    public void MakeSphere()
    {
        // Wir erstellen die Kugel und speichern sie in der globalen Variable
        _goMySphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        // Wir setzen die Position der Kugel mit X und Y, Z bleibt 0 (für 2D-Ebene)
        _goMySphere.transform.position = new Vector3(positionOfSphereX, positionOfSphereY, 0);
    }

    // Diese Methode erzeugt vier weitere Kugeln um die mittlere herum (wie ein Pluszeichen)
    [ButtonMethod]
    public void MakeSphereStar()
    {
        // Sicherheitsabfrage: Falls die mittlere Kugel noch nicht erstellt wurde
        if (_goMySphere == null)
        {
            Debug.LogWarning("Bitte zuerst MakeSphere() aufrufen!");
            return; // Methode hier beenden, um Fehler zu vermeiden
        }

        // Wir holen uns die Position der mittleren Kugel
        Vector3 mitte = _goMySphere.transform.position;

        // Wir durchlaufen 4 Schritte: oben, unten, links, rechts
        for (int i = 0; i < 4; i++)
        {
            // Neue Kugel erzeugen
            GameObject star = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            // Basisposition ist die Mitte
            Vector3 pos = mitte;

            // Je nach Schleifenzahl setzen wir die Position in eine Richtung
            switch (i)
            {
                case 0: // Kugel über der Mitte
                    pos += Vector3.up;
                    break;
                case 1: // Kugel unter der Mitte
                    pos += Vector3.down;
                    break;
                case 2: // Kugel links von der Mitte
                    pos += Vector3.left;
                    break;
                case 3: // Kugel rechts von der Mitte
                    pos += Vector3.right;
                    break;
            }

            // Setze die berechnete Position auf die neue Kugel
            star.transform.position = pos;

            // Mache die Kugel zum Kind der mittleren Kugel
            // → Wenn die mittlere bewegt wird, folgen alle "Kinder" mit
            star.transform.parent = _goMySphere.transform;
        }
    }
}