using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
   public int puntuacionJugadorIzq = 0;

   public int puntuacionJugadorDer = 0;

   public event UnityAction OnPauseGame;

   public event UnityAction OnRestartGame;

   //jugador = 0 -> jugador izquierda
   //jugador = 1 -> jugador derecha

   public void Goal(int jugador){

    if( jugador == 0)
    {
        puntuacionJugadorIzq = puntuacionJugadorIzq + 1;
        Debug.Log(puntuacionJugadorIzq);
    }else
    {
        puntuacionJugadorDer++;
        Debug.Log(puntuacionJugadorDer);
    }
    OnPauseGame.Invoke();
   }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Reinicar Juego
            
            
            
            
            OnRestartGame.Invoke();
        }
    }

}
