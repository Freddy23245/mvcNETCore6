function mostrarModal() {
    var modal = document.getElementById('myModalUpdate');
    $(modal).modal('show');
}
const utils1 = {
    ajaxPost: (url, model, callback, callbackError) => {
        $.post(url, model)
            .done(callback)
            .fail(callbackError);
    },
};

const update = {
    init: () => {
        update.componentes = {
            cuil: $('#cuil'),
            ApellidoYNombre: $('#ApellidoYNombre'),
            botonAgregar: $('#botonAgregar'),
            UrlPostPersonas: $('#UrlPostPersonas')
        };
        update.componentes.botonAgregar.on('click', update.acciones.botonClick)
    },
    componentes: {
        cuil: undefined,
        ApellidoYNombre: undefined,
        UrlPostPersonas: undefined,
        botonAgregar: undefined
    },
    acciones: {
        botonClick: () => {
            const url = update.componentes.UrlPostPersonas.val();
            const model = {
                persona: {
                    cuil: update.componentes.cuil.val(),
                    ApellidoYNombre: update.componentes.ApellidoYNombre.val()
                }

            };
            console.log(model);
            utils1.ajaxPost(url, model,
                (data) => {
                    mostrarModal();
                }

            );
        }
    }
}