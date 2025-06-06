const acessibilidade = () => {
    const caminhoAtalho = host => ("https://" + host + "/Home/Acessibilidade");

    return {
        caminhoAtalho
        }
}

const home = () => {
    const caminhoAtalho = host => ("https://" + host + "/Home");
    return {
        caminhoAtalho
    }
}

const contatos = () => {
    const caminhoAtalho = host => ("https://" + host + "/Home/Contatos");
    return {
        caminhoAtalho
    }
}
 
const topoDaPagina = () => window.scrollTo(0, 0);

 
const handleKeyName = (name) => {
    const mapper_atalhos =
    {
        'a': acessibilidade,
        '0': home,
        '1': topoDaPagina,
        '2': contatos
    }
    return mapper_atalhos[name.toLowerCase()] ? mapper_atalhos[name.toLowerCase()]() : null
}

const strategyAtalho = () => {
    let strategy;
    const host = window.location.host;
    const addStrategy = newStrategy => strategy = newStrategy;

    const executar = () => {
        
        if (strategy instanceof Function) {
            strategy()
            return
        }
        window.location.href = strategy.caminhoAtalho(host)
    }

    return {
        addStrategy,
        executar
    }
}

const handleKeyDown = (e) => {
    if (e.altKey) {
        e.preventDefault();
        const context = strategyAtalho();
        if (!handleKeyName(e.key))
            return
        const strategy = handleKeyName(e.key)

        context.addStrategy(strategy);
        context.executar();
    }
}

document.querySelector('body').addEventListener('keydown', handleKeyDown)