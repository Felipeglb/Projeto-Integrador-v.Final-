<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../Bootstrap/bootstrap.css">
    <title>Document</title>
</head>

<body class="bg-dark">
    <script src="../JavaScript/bootstrap.bundle.js"></script>
    <script src="../Jquery/jquery-3.6.4.js"></script>

    <div class="container mt-6">
        <form action="" class="form-control" method="POST" id="frmDor">
            <div class="row">
                <div class="col-sm-12">
                    <h1>Média Escolar</h1>
                </div>
                <hr>


                <div class="col-sm-6">
                    <p><input type="number" step="0.1" placeholder="Insira N1" id="txtN1" name="txtN1" class="form-control notas" required></p>
                    <p><input type="number" step="0.1" placeholder="Insira N2" id="txtN2" name="txtN2" class="form-control notas" required></p>
                    <p><input type="number" step="0.1" placeholder="Insira N3" id="txtN3" name="txtN3" class="form-control notas" required></p>
                    <p><input type="number" step="0.1" placeholder="Insira N4" id="txtN4" name="txtN4" class="form-control notas" required></p>
                    <p><button class=" btn btn-success" id="btoCalcular" formaction="NotasEscolares.php">Verificar</button></p>
                    <p><a class="btn btn-danger" href="NotasEscolares.php">Limpar</a></p>
                </div>
                <div class="col-sm-3 p3">
                    
                </div>

                <hr>
                <div class="col-sm-8 text-center">
                    <?php
                    if ($_POST) 
                    {

                        $n1 = $_POST["txtN1"];
                        $n2 = $_POST["txtN2"];
                        $n3 = $_POST["txtN3"];
                        $n4 = $_POST["txtN4"];
                        $status = "";
                        $total = ($n1 + $n2 + $n3 + $n4) / 4;

                        if ($total < 5) {
                            $status= "Reprovado";
                        }

                        if ($total >= 5) {
                            $status= "Recuperação";
                        }

                        if ($total > 6) {
                            $status= "Aprovado";
                        }
                        echo "<h3>A média do alune: $total; situação: $status .</h3>";
                    }
                    ?>
                </div>
            </div>
        </form>
    </div>

    <script>
        $('#frmDor').submit(function(e) {
            let n1 = $('#txtN1').val();
            let n2 = $('#txtN2').val();
            let n3 = $('#txtN3').val();
            let n4 = $('#txtN4').val();

            if (!$.isNumeric(n1)) 
            {
                alert("erro, o N1 deve ser numérico");
                e.preventDefault();
                $('#txtN1').val("");
                $('#txtN1').focus();
                return;
            } else if (n1 > 10 || n1 < 0) 
            {
                alert("erro, o N1 deve estar entre 0 e 10");
                e.preventDefault();
                $('#txtN1').val("");
                $('#txtN1').focus();
                return;
            }

            if (!$.isNumeric(n2)) 
            {
                alert("erro, o N2 deve ser numérico");
                e.preventDefault();
                $('#txtN2').val("");
                $('#txtN2').focus();
                return;
            } 
            else if (n2 > 10 || n2 < 0) {
                alert("erro, o N2 deve estar entre 0 e 10");
                e.preventDefault();
                $('#txtN2').val("");
                $('#txtN2').focus();
                return;
            }

            if (!$.isNumeric(n3)) 
            {
                alert("erro, o N3 deve ser numérico");
                e.preventDefault();
                $('#txtN3').val("");
                $('#txtN3').focus();
                return;
            } 
            else if (n3 > 10 || n3 < 0) 
            {
                alert("erro, o N3 deve estar entre 0 e 10");
                e.preventDefault();
                $('#txtN3').val("");
                $('#txtN3').focus();
                return;
            }

            if (!$.isNumeric(n4)) 
            {
                alert("erro, o N4 deve ser numérico");
                e.preventDefault();
                $('#txtN4').val("");
                $('#txtN4').focus();
                return;
            } 
            else if (n4 > 10 || n4 < 0) 
            {
                alert("erro, o N4 deve estar entre 0 e 10");
                e.preventDefault();
                $('#txtN4').val("");
                $('#txtN4').focus();
                return;
            }


        });
    </script>


</body>

</html>