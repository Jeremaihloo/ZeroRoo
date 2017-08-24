<template>
  <div id="app">
    <files-container :style="{height:fcHeight+'px'}" class="files-container"></files-container>
    <applications-container :style="{height:fcHeight+'px',width:acWidth+'px'}" class="activities-container"></applications-container>
  </div>
</template>

<script>
import FilesContainer from './components/FilesContainer'
import ApplicationsContainer from './components/ActivitiesContainer'

export default {
  name: 'app',
  components: {
    FilesContainer,
    ApplicationsContainer
  },
  data () {
    return {
      fcHeight: 800,
      acWidth: 100
    }
  },
  mounted () {
    let resize = () => {
      this.fcHeight = window.innerHeight - 5
      this.acWidth = window.innerWidth - 110
    }
    window.onresize = () => {
      resize()
    }
    resize()
  }
}
</script>

<style lang="less" rel="stylesheet/less">
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  display: flex;
}

.files-container {
  width: 100px;
  overflow: scroll;
}

.activities-container {
  width: 100%;
  flex: 1;
  padding: 5px;
}
</style>
