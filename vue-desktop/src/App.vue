<template>
  <div id="app">
    <files-container></files-container>
  </div>
</template>

<script>
import FilesContainer from './components/FilesContainer'

export default {
  name: 'app',
  components: {
    FilesContainer
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}
</style>
