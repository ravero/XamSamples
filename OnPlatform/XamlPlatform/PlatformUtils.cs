using System;
using System.Linq;
using Xamarin.Forms;

namespace XamlPlatform
{
    public static class PlatformUtils
    {
        /// <summary>
        /// Atalho para obter um valor de acordo com a plataforma em que o código esta sendo executado.
        /// </summary>
        /// <typeparam name="T">Tipo de dado do valor a ser obtido.</typeparam>
        /// <param name="defValue">Valor padrão, caso nenhuma plataforma seja especificada.</param>
        /// <param name="platformValues">Um array (params) com uma tupla descrevendo a plataforma e o valor que a plataforma deve assumir.</param>
        /// <returns>O valor, de acordo com a plataforma em que o método for executado.</returns>
        public static T OnPlatform<T>(T defValue, params (string, T)[] platformValues) {
            foreach (var pv in platformValues) {
                if (pv.Item1 == Device.RuntimePlatform)
                    return pv.Item2;
            }
            return defValue;
        }

        /// <summary>
        /// Atalho alternativo para obter um valor de acordo com a plataforma em que o código esta sendo executado.
        /// </summary>
        /// <param name="platformActions">Um array (params) de tuplas com a descrição da plataforma e uma Action executando a operação para aquela plataforma.</param>
        public static void OnPlatform(params (string, Action)[] platformActions) =>
            platformActions.ToList().ForEach(pa => {
                if (pa.Item1 == Device.RuntimePlatform)
                    pa.Item2();
            });
    }
}
