<template>
  <div class="home">
      <div class="form">
        <input type="text" v-model="username" placeholder="Escribe Usuario" class="username">
        <button class="btnSubmit" @click="SendData">Enviar</button>
      </div>
  </div>
</template>

<style>
  body{
    background: #212121;
  }
  .username{
    padding: 25px;
    border: none;
    border-bottom: 4px solid green;
    background: #424242;
    color: white;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    font-size: 20px;
    width: 40%;
    text-align: center;
    border-radius: 4px;
    position: relative;
    top: 300px;
    outline: none;
  }
  .btnSubmit{
    padding: 15px;
    border: none;
    background: green;
    color: white;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    width: 50%;
    position: absolute;
    border-radius: 4px;
    left: 25%;
    height: 100px;
    top: 600px;
    font-size: 16px;
    transition: all 0.3s ease;
    outline: none;
  }
  .btnSubmit:hover{
    transform: scale(1.1);
    cursor: pointer;
  }
</style>

<script>
import axios from 'axios';
export default {
  name: 'home',
  data: function () {
    return {
      username: '',
      errors: [],
      complete: [],
    }
  },
  methods: {
      SendData(){
        axios.post(`https://localhost:44329/api/prueba`, { body: this.username })
        .then(response => { alert(this.username, response) })
        .catch(e => { this.errors.push(e) })

        
      }
    }
}
</script>
