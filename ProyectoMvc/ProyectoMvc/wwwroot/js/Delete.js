const utils2 = {
    ajaxPost: (url, model, callback, callbackError) => {
        $.post(url, model)
            .done(callback)
            .fail(callbackError);
    },
};

const del = {
    init: () => {
        del.componentes = {

            btnID: $('#btnID'),
            UrlPostPersonas: $('#UrlPostPersonasD')
        };

        del.componentes.btnID.on('click', del.acciones.botonClick)
    },
    componentes: {
        btnID: undefined,
        UrlPostPersonas: undefined
    },
    acciones: {
        botonClick: () => {
            const url = del.componentes.UrlPostPersonas.val();
            const model = {

            };
            console.log(model);
            utils2.ajaxPost(url, model,
                (data) => {

                }

            );
        }
    }
}