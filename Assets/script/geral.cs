using UnityEngine;
using UnityEngine.UI;

public class geral : MonoBehaviour
{
    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public AudioSource somPontoGanho, somPerdeu;

    public GameObject telaBoasVindas, telaGameOver;
    public ControladorVoador objetoVoador;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        //recordeNum = 0;

        Time.timeScale = 0;

        AtualizarTextoPlacar();


    }

    public void MarcarPonto()

    {
        placarJogadorNum += 1;

        if (recordeNum < placarJogadorNum)
            recordeNum += 1;

        AtualizarTextoPlacar();

        somPontoGanho.Play();

    }

    public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados: " + placarJogadorNum;
        recordeTexto.text = "Recorde atual: " + recordeNum;
    }

    public void ComecarJogo()

    {
        //descongela o tempo
        Time.timeScale = 1;

        //sumir com aas telas de boas vindas e game over
        telaBoasVindas.SetActive(false);
        telaGameOver.SetActive(false);

        //voltar o objeto voador a posiçao inicial
        objetoVoador.deslocamentoAbs = objetoVoador.deslocamentoObjeto;
        objetoVoador.posicaoObj.x = objetoVoador.posInicialX;

        //zerar o placar
        placarJogadorNum = 0;
        AtualizarTextoPlacar();

    }





}
