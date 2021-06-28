using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDifusa
{
    public partial class Form1 : Form
    {
        float ataqueFisico = 0;
        float ataqueDistancia = 0;

        public Form1()
        {
            InitializeComponent();
            cbElemento.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
            cbPatron.SelectedIndex = 0;
            cbPapel.SelectedIndex = 0;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            ataqueFisico = 0;
            ataqueDistancia = 0;

            // Selección del elemento
            if (spinnerEstado.Value - spinnerElemento.Value >= 2 || spinnerElemento.Value == 0)
            {
                if(spinnerEstado.Value > 0)
                {
                    switch (cbEstado.SelectedItem)
                    {
                        case "Nitro":
                            pbElemento.Image = iconosElementos.Images["estado_nitro.png"];
                            break;

                        case "Paralisis":
                            pbElemento.Image = iconosElementos.Images["estado_paralisis.png"];
                            break;

                        case "Sueño":
                            pbElemento.Image = iconosElementos.Images["estado_sueño.png"];
                            break;

                        case "Veneno":
                            pbElemento.Image = iconosElementos.Images["estado_veneno.png"];
                            break;
                    }
                }
            }
            else if(spinnerElemento.Value == 0 && spinnerEstado.Value == 0)
            {
                pbElemento.Image = iconosElementos.Images["arma_oculta.png"];
            }
            else
            {
                if(spinnerElemento.Value > 0)
                {
                    switch (cbElemento.SelectedItem)
                    {
                        case "Fuego":
                            pbElemento.Image = iconosElementos.Images["elemento_fuego.png"];
                            break;

                        case "Hielo":
                            pbElemento.Image = iconosElementos.Images["elemento_hielo.png"];
                            break;

                        case "Draco":
                            pbElemento.Image = iconosElementos.Images["elemento_draco.png"];
                            break;

                        case "Rayo":
                            pbElemento.Image = iconosElementos.Images["elemento_rayo.png"];
                            break;

                        case "Agua":
                            pbElemento.Image = iconosElementos.Images["elemento_agua.png"];
                            break;
                    }
                }
            }

            //Suma de puntos al tipo de ataque

            //Tipo ataque
            switch(cbTipo.SelectedItem)
            {
                case "Elemental":
                    ataqueDistancia = ataqueDistancia + 2;
                    break;

                case "Estado":
                    ataqueDistancia = ataqueDistancia + 1;
                    ataqueFisico = ataqueFisico + 1;
                    break;

                case "Fisico":
                    ataqueFisico = ataqueFisico + 1.75f;
                    ataqueDistancia = ataqueDistancia + 0.25f;
                    break;
            }

            if(cbPatron.SelectedIndex == 0)
            {
                ataqueDistancia = ataqueDistancia + 2;
                ataqueFisico = ataqueFisico + 1f;
            }
            else
            {
                ataqueDistancia = ataqueDistancia + 1f;
                ataqueFisico = ataqueFisico + 2;
            }

            switch(trackTamano.Value)
            {
                case 1:
                    ataqueFisico = ataqueFisico + 1;
                    ataqueDistancia = ataqueDistancia + 0.25f;
                    break;

                case 2:
                    ataqueFisico = ataqueFisico + 0.75f;
                    ataqueDistancia = ataqueDistancia + 0.5f;
                    break;

                case 3:
                    ataqueFisico = ataqueFisico + 0.5f;
                    ataqueDistancia = ataqueDistancia + 0.75f;
                    break;

                case 4:
                    ataqueFisico = ataqueFisico + 0.25f;
                    ataqueDistancia = ataqueDistancia + 1;
                    break;
            }

            if(ataqueDistancia > ataqueFisico)
            {
                if(spinnerElemento.Value > 2)
                {
                    pbArma.Image = iconosArmas.Images["arco.png"];
                }
                else
                {
                    if(trackTamano.Value > 2)
                    {
                        pbArma.Image = iconosArmas.Images["ballesta_pesada.png"];
                    }
                    else
                    {
                        pbArma.Image = iconosArmas.Images["ballesta_ligera.png"];
                    }
                }
            }
            else if(ataqueFisico > ataqueDistancia)
            {
                if(spinnerElemento.Value >= 2 || spinnerEstado.Value >= 2)
                {
                    if(cbPapel.SelectedIndex == 0)
                    {
                        pbArma.Image = iconosArmas.Images["espadas_duales.png"];
                    }
                    else
                    {
                        switch (cbPapel.SelectedItem)
                        {
                            case "Daño rapido":
                                pbArma.Image = iconosArmas.Images["espadas_duales.png"];
                                break;

                            case "Soporte":
                                pbArma.Image = iconosArmas.Images["espada_y_escudo.png"];
                                break;

                            case "Tanque":
                                pbArma.Image = iconosArmas.Images["espada_y_escudo.png"];
                                break;
                        }
                    }
                }
                else
                {
                    if (cbPapel.SelectedIndex == 0)
                    {
                        switch(trackTamano.Value)
                        {
                            case 1:
                                pbArma.Image = iconosArmas.Images["hacha_cargada.png"];
                                break;

                            case 2:
                                pbArma.Image = iconosArmas.Images["martillo.png"];
                                break;

                            case 3:
                                pbArma.Image = iconosArmas.Images["hacha_espada.png"];
                                break;

                            case 4:
                                pbArma.Image = iconosArmas.Images["gran_espada.png"];
                                break;
                        }
                    }
                    else
                    {
                        switch (cbPapel.SelectedItem)
                        {
                            case "Daño rapido":
                                pbArma.Image = iconosArmas.Images["espada_larga.png"];
                                break;

                            case "Soporte":
                                pbArma.Image = iconosArmas.Images["cornamusa.png"];
                                break;

                            case "Tanque":
                                pbArma.Image = iconosArmas.Images["lanza_y_escudo.png"];
                                break;
                        }
                    }
                }
            }
            else
            {
                if(cbPapel.SelectedIndex == 0)
                {
                    switch(cbPapel.SelectedItem)
                    {
                        case "Daño rapido":
                            pbArma.Image = iconosArmas.Images["glaive_de_insecto.png"];
                            break;

                        case "Soporte":
                            pbArma.Image = iconosArmas.Images["lanza_pistola.png"];
                            break;

                        case "Tanque":
                            pbArma.Image = iconosArmas.Images["lanza_pistola.png"];
                            break;
                    }
                }
                else
                {
                    if(spinnerElemento.Value >= 2 || spinnerEstado.Value >= 2)
                    {
                        pbArma.Image = iconosArmas.Images["glaive_de_insecto.png"];
                    }
                    else
                    {
                        pbArma.Image = iconosArmas.Images["lanza_pistola.png"];
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbElemento.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
            cbPatron.SelectedIndex = 0;
            cbPapel.SelectedIndex = 0;
            spinnerElemento.Value = 0;
            spinnerEstado.Value = 0;

            ataqueFisico = 0;
            ataqueDistancia = 0;

            pbElemento.Image = iconosElementos.Images["arma_oculta.png"];
            pbArma.Image = iconosArmas.Images["arma_oculta.png"];
        }
    }
}
