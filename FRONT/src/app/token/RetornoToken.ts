export interface RetornoConsultaDivida {
    Success: boolean;
    Codigo: null;
    Message: string;
    Data: Data;
    Propriety: null;
}

export interface Data {
    token: string;
    dados: Dados;
}

export interface Dados {
    ClienteId: number;
    ContId: number;
    Nome: string;
    CPF: string;
    Oferta: string;
    DeltaPreco: string;
    PrecoFinal: number;
    DetalheOferta: string;
}
